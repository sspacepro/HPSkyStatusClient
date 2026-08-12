using HPSkyStatusClient.Services;
using System.Diagnostics;
using System.Reflection;


namespace HPSkyStatusClient;

public partial class MainForm : Form
{
    private NotifyIcon _trayIcon;
    private readonly System.Windows.Forms.Timer _timer;

    private readonly Icon _greenIcon;
    private readonly Icon _yellowIcon;
    private readonly Icon _redIcon;
    private readonly Icon _greenNotifyIcon;
    private readonly Icon _yellowNotifyIcon;
    private readonly Icon _redNotifyIcon;

    private bool _auctionAlertActive;
    private readonly StatusService _statusService;
    private readonly AuctionWatchService _auctionWatchService;
    private readonly IServiceProvider _serviceProvider;
    private readonly ClientSettingsApiService _clientSettings;
    private readonly NotificationService _notifications;
    private readonly NotificationApiService _notificationApiService;
    private readonly NotificationTimeService _notificationTime;
    private readonly ClientSettingsService _localSettings;
    private readonly ClientPreferencesService _preferences;
    private ToolStripMenuItem _trayServerItem = null!;
    private ToolStripMenuItem _trayPlayersItem = null!;
    private readonly List<ToolStripMenuItem> _trayAuctionItems = new();
    private ToolStripSeparator _trayAuctionSeparator = null!;
    private ToolStripMenuItem _trayUpdatedItem = null!;
    private ToolStripMenuItem _trayRefreshItem = null!;
    private readonly AdminApiService _adminApi;
    private readonly ItemCacheService _itemCache;
    private readonly ApiService _apiService;
    private readonly CancellationTokenSource _shutdownCts = new();
    private bool _isAdmin;

    public MainForm(
        StatusService statusService,
        AuctionWatchService auctionWatchService,
        IServiceProvider serviceProvider,
        ClientSettingsApiService clientSettings,
        NotificationApiService notificationApiService,
        NotificationTimeService notificationTime,
        ClientSettingsService localSettings,
        ClientPreferencesService preferences,
        AdminApiService adminApi,
        ItemCacheService itemCache,
        ApiService apiService)
    {
        _statusService = statusService;
        _auctionWatchService = auctionWatchService;
        _serviceProvider = serviceProvider;
        _clientSettings = clientSettings;
        _notificationApiService = notificationApiService;
        _notificationTime = notificationTime;
        _localSettings = localSettings;
        _preferences = preferences;
        _adminApi = adminApi;
        _itemCache = itemCache;
        _apiService = apiService;




       
        _greenIcon = LoadIcon("skyblock-green.ico");
        _yellowIcon = LoadIcon("skyblock-yellow.ico");
        _redIcon = LoadIcon("skyblock-red.ico");
        _greenNotifyIcon = LoadIcon("skyblock-green-notify.ico");
        _yellowNotifyIcon = LoadIcon("skyblock-yellow-notify.ico");
        _redNotifyIcon = LoadIcon("skyblock-red-notify.ico");

        InitializeComponent();
        _preferences.Load();
        LoadClientSettings();

        var font = CustomFontService.LoadFont("minecraft_font.ttf", 7.5f);
        ApplyFont(this, font);

        _trayIcon = new NotifyIcon
        {
            Icon = LoadIcon("skyblock.ico"),
            Text = "HPSkyStatus",
            Visible = true
        };
        _notifications = new NotificationService(_trayIcon);

        var menu = new ContextMenuStrip();
        menu.Renderer = new SkyBlockMenuRenderer();

        _trayServerItem = new ToolStripMenuItem("SkyBlock: Unknown");
        _trayPlayersItem = new ToolStripMenuItem("Players: ?");
        _trayUpdatedItem = new ToolStripMenuItem("Updated: Never");

        menu.Items.Add(_trayServerItem);
        menu.Items.Add(_trayPlayersItem);
        menu.Items.Add(_trayUpdatedItem);

        _trayAuctionSeparator = new ToolStripSeparator();
        menu.Items.Add(_trayAuctionSeparator);

        menu.Items.Add("Open", null, (_, _) =>
        {
            Show();
            WindowState = FormWindowState.Normal;
        });

        _trayRefreshItem = new ToolStripMenuItem("Refresh Now");
        _trayRefreshItem.Click += async (_, _) =>
        {
            _trayRefreshItem.Text = "Refreshing...";
            try
            {
                await UpdateStatus();
                await CheckNotifications(false);
                await UpdateAuctions();
                UpdateTrayUpdatedTime();
            }
            finally
            {
                _trayRefreshItem.Text = "Refresh Now";
            }
        };

        menu.Items.Add(_trayRefreshItem);

        menu.Items.Add("Settings", null, (_, _) =>
        {
            Show();
            WindowState = FormWindowState.Normal;
            tabMain.SelectedTab = pgSettings;
        });

        menu.Items.Add(new ToolStripSeparator());

        menu.Items.Add("Exit", null, (_, _) =>
        {
            _trayIcon.Dispose();
            Application.Exit();
        });

        _trayIcon.ContextMenuStrip = menu;

        _trayIcon.DoubleClick += (_, _) =>
        {
            Show();
            WindowState = FormWindowState.Normal;
        };

        _timer = new System.Windows.Forms.Timer();
        _timer.Interval = 60000;
        _timer.Tick += async (_, _) =>
        {
            await UpdateStatus();
            await UpdateAuctions();
            await CheckNotifications(false);
            UpdateTrayUpdatedTime();
        };
        _timer.Start();

        // Initial load on a background thread, then marshal UI updates to the UI thread
        _ = Task.Run(async () =>
        {
            try
            {
                await _clientSettings.Refresh();
                await _itemCache.Load();

                await InvokeAsync(
                    async (cancellationToken) =>
                    {
                        await UpdateStatus();
                        await CheckNotifications(true);
                        UpdateTrayUpdatedTime();
                        await UpdateAuctions();
                        LoadServerSettings();
                        ShowTrayIconPrompt();
                    },
                    _shutdownCts.Token);
            }
            catch (Exception ex)
            {
                if (IsHandleCreated)
                {
                    await InvokeAsync(
                        () =>
                        {
                            MessageBox.Show(
                                $"Failed to initialize: {ex.Message}",
                                "HPSkyStatus",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        },
                        _shutdownCts.Token);
                }
            }
        });
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (!_isAdmin && _preferences.Preferences.MinimizeToTray &&
            e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            Hide();
            return;
        }
        _shutdownCts.Cancel();
        _shutdownCts.Dispose();

        _timer?.Stop();
        _timer?.Dispose();
        _trayIcon?.Dispose();

        base.OnFormClosing(e);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        tabMain.TabPages.Remove(pgAdmin);
    }

    private void txtServerUrl_TextChanged(object sender, EventArgs e)
    {
        // Server URL changes are saved via the Save button
    }

    private static void ApplyFont(Control control, Font font)
    {
        control.Font = font;

        foreach (Control child in control.Controls)
            ApplyFont(child, font);
    }

    private void UpdateTrayIcon(bool online, bool maintenance, int playerCount)
    {
        if (!online)
        {
            _trayIcon.Icon = _auctionAlertActive ? _redNotifyIcon : _redIcon;
            _trayIcon.Text = _auctionAlertActive
                ? "Hypixel Offline - Auction Alert"
                : "Unable to connect to Hypixel";
            return;
        }

        if (maintenance)
        {
            _trayIcon.Icon = _auctionAlertActive ? _yellowNotifyIcon : _yellowIcon;
            _trayIcon.Text = _auctionAlertActive
                ? "SkyBlock Maintenance - Auction Alert"
                : $"SkyBlock Maintenance - {playerCount} players";
            return;
        }

        _trayIcon.Icon = _auctionAlertActive ? _greenNotifyIcon : _greenIcon;
        _trayIcon.Text = _auctionAlertActive
            ? "SkyBlock Online - Auction Alert"
            : $"SkyBlock Online - {playerCount} players";
    }
    public async Task OpenAdminTab()
    {
        _isAdmin = true;

        if (!tabMain.TabPages.Contains(pgAdmin))
        {
            tabMain.TabPages.Insert(2, pgAdmin);
        }

        await LoadAdminSettings();
        await RefreshUsers();

        tabMain.SelectedTab = pgAdmin;
    }
    private static Icon LoadIcon(string name)
    {
        var assembly = Assembly.GetExecutingAssembly();
        foreach (var resource in Assembly.GetExecutingAssembly().GetManifestResourceNames())
        {
            Console.WriteLine(resource);
        }
        using var stream =
            assembly.GetManifestResourceStream(
                $"HPSkyStatusClient.{name}")
            ?? throw new FileNotFoundException(
                $"Embedded resource not found: {name}");

        return new Icon(stream);
    }
    private void ShowTrayIconPrompt()
    {
        if (_preferences.Preferences.TrayIconPromptShown)
            return;

        _preferences.Preferences.TrayIconPromptShown = true;
        _preferences.Save();

        var result = MessageBox.Show(
            "For easy access, add the HPSkyStatus tray icon to your taskbar.\n\n" +
            "Go to Settings → Other system tray icons and enable HPSkyStatus.",
            "HPSkyStatus",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information);

        if (result == DialogResult.OK)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "ms-settings:taskbar",
                UseShellExecute = true
            });
        }
    }


}