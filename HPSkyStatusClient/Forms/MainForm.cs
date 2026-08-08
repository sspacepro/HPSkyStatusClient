using HPSkyStatusClient.Configuration;
using HPSkyStatusClient.Forms;
using HPSkyStatusClient.Models;
using HPSkyStatusClient.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
namespace HPSkyStatusClient;


public partial class MainForm : Form
{
    private NotifyIcon _trayIcon;

    private readonly Icon _greenIcon;
    private readonly Icon _yellowIcon;
    private readonly Icon _redIcon;
    private readonly StatusService _statusService;
    //private readonly PlayerWatchService _playerWatchService;
    private readonly AuctionWatchService _auctionWatchService;
    private readonly IServiceProvider _serviceProvider;
    private readonly ApiErrorService _errorService;
    private readonly ClientSettingsApiService _clientSettings;
    private NotificationService _notifications;
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
    private readonly ItemCacheService _items;
    private readonly ItemCacheService _itemCache;
    private readonly ApiService _apiService;
    public MainForm(
        StatusService statusService,
        //PlayerWatchService playerWatchService,
        AuctionWatchService auctionWatchService,
        IServiceProvider serviceProvider,
        ApiErrorService errorService,
        ClientSettingsApiService clientSettings,
        NotificationApiService notificationApiService,
        NotificationTimeService notificationTime,
        ClientSettingsService localSettings,
        ClientPreferencesService preferences,
        AdminApiService adminApi,
        ItemCacheService items,
        ItemCacheService itemCache,
        ApiService apiService)
    {
        _statusService = statusService;
        //_playerWatchService = playerWatchService;
        _auctionWatchService = auctionWatchService;
        _serviceProvider = serviceProvider;
        _errorService = errorService;
        _clientSettings = clientSettings;
        _notificationApiService = notificationApiService;
        _notificationTime = notificationTime;
        _localSettings = localSettings;
        _preferences = preferences;
        _adminApi = adminApi;
        _items = items;
        _itemCache = itemCache;
        _apiService = apiService;



        _preferences.Load();
        _greenIcon = new Icon("skyblock-green.ico");
        _yellowIcon = new Icon("skyblock-yellow.ico");
        _redIcon = new Icon("skyblock-red.ico");

        InitializeComponent();

        _trayIcon = new NotifyIcon
        {
            Icon = new Icon("skyblock.ico"),
            Text = "HPSkyStatus",
            Visible = true
        };
        _notifications = new NotificationService(_trayIcon);


        var menu = new ContextMenuStrip();
        menu.Renderer = new SkyBlockMenuRenderer();

        _trayServerItem = new ToolStripMenuItem("SkyBlock: Unknown");

        _trayServerItem.Click += (_, _) => { };

        _trayPlayersItem = new ToolStripMenuItem("Players: ?");
        _trayPlayersItem.Click += (_, _) => { };

        _trayUpdatedItem = new ToolStripMenuItem("Updated: Never");
        _trayUpdatedItem.Click += (_, _) => { };

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
            var position = Cursor.Position;
            try
            {
                await UpdateStatus();
                //await UpdatePlayers();
                await CheckNotifications(false);

                UpdateTrayUpdatedTime();
                await UpdateAuctions();
            }
            finally
            {
                _trayRefreshItem.Text = "Refresh Now";
            }
            //hu
            BeginInvoke(() =>
            {
                _trayIcon.ContextMenuStrip?.Show(position);
            });
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




        _trayIcon.ContextMenuStrip = menu;

        _trayIcon.DoubleClick += (_, _) =>
        {
            Show();
            WindowState = FormWindowState.Normal;
        };

        var timer = new System.Windows.Forms.Timer();

        timer.Interval = 60000;

        timer.Tick += async (_, _) =>
        {
            await UpdateStatus();
            //await UpdatePlayers();
            await UpdateAuctions();
            await CheckNotifications(false);
            UpdateTrayUpdatedTime();
        };

        timer.Start();

        _ = Task.Run(async () =>
        {
            await _clientSettings.Refresh();
            Invoke(() =>
            {
                LoadClientSettings();
                LoadServerSettings();
            });

            await UpdateStatus();
            //await UpdatePlayers();
            await CheckNotifications(true);
            await _items.Load();
            UpdateTrayUpdatedTime();
            await UpdateAuctions();
        });
        _itemCache = itemCache;
    }


    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (_preferences.Preferences.MinimizeToTray &&
            e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            Hide();
            return;
        }

        base.OnFormClosing(e);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        //Place to test thins on startup.
        this.pgAdmin.Hide();
        tabMain.TabPages.Remove(pgAdmin);

    }

    private void txtServerUrl_TextChanged(object sender, EventArgs e)
    {

    }

}