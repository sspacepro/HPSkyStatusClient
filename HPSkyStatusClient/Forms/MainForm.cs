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
    private readonly PlayerWatchService _playerWatchService;
    private readonly AuctionWatchService _auctionWatchService;
    private bool _serverOnline;
    private readonly IServiceProvider _serviceProvider;
    private readonly ApiErrorService _errorService;
    private readonly ClientSettingsApiService _clientSettings;
    private NotificationService _notifications;
    private readonly NotificationApiService _notificationApiService;
    private readonly NotificationTimeService _notificationTime;
    private readonly ClientSettingsService _localSettings;
    private readonly ClientPreferencesService _preferences;
    private readonly IOptions<ApiSettings> _apiSettings;

    public MainForm(
        StatusService statusService,
        PlayerWatchService playerWatchService,
        AuctionWatchService auctionWatchService,
        IServiceProvider serviceProvider,
        ApiErrorService errorService,
        ClientSettingsApiService clientSettings,
        NotificationApiService notificationApiService,
        NotificationTimeService notificationTime,
        ClientSettingsService localSettings,
        ClientPreferencesService preferences,
        IOptions<ApiSettings> apiSettings)
    {
        _statusService = statusService;
        _playerWatchService = playerWatchService;
        _auctionWatchService = auctionWatchService;
        _serviceProvider = serviceProvider;
        _errorService = errorService;
        _clientSettings = clientSettings;
        _notificationApiService = notificationApiService;
        _notificationTime = notificationTime;
        _localSettings = localSettings;
        _preferences = preferences;
        _apiSettings = apiSettings;



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

        menu.Items.Add("Open", null, (_, _) =>
        {
            Show();
            WindowState = FormWindowState.Normal;
        });

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

        var timer = new System.Windows.Forms.Timer();

        timer.Interval = 60000;

        timer.Tick += async (_, _) =>
        {
            await UpdateStatus();
            await UpdatePlayers();
            await UpdateAuctions();
            await CheckNotifications(false);
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
            await UpdatePlayers();
            await UpdateAuctions();
            await CheckNotifications(true);
        });
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
        
    }


}