using HPSkyStatusClient.Configuration;
using HPSkyStatusClient.Forms;
using HPSkyStatusClient.Services;
using Microsoft.Extensions.DependencyInjection;
namespace HPSkyStatusClient;


public partial class MainForm : Form
{
    private NotifyIcon _trayIcon;

    private readonly Icon _greenIcon;
    private readonly Icon _yellowIcon;
    private readonly Icon _redIcon;
    private readonly StatusService _statusService;
    private readonly PlayerWatchService _playerWatchService;
    private bool _serverOnline;
    private readonly IServiceProvider _serviceProvider;
    private readonly ApiErrorService _errorService;
    private readonly ClientSettingsApiService _clientSettings;
    public MainForm(
        StatusService statusService,
        PlayerWatchService playerWatchService,
        IServiceProvider serviceProvider,
        ApiErrorService errorService,
        ClientSettingsApiService clientSettings)
    {
        _statusService = statusService;
        _playerWatchService = playerWatchService;
        _serviceProvider = serviceProvider;
        _errorService = errorService;
        _clientSettings = clientSettings;

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
        };

        timer.Start();

        _ = Task.Run(async () =>
        {
            await _clientSettings.Refresh();
            await UpdateStatus();
            await UpdatePlayers();
        });
    }


    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing)
        {
            e.Cancel = true;
            Hide();
        }

        base.OnFormClosing(e);
    }

    private async Task UpdateStatus()
    {
        var status = await _statusService.GetStatus();

        if (status == null)
        {
            _serverOnline = false;

            _trayIcon.Icon = _redIcon;
            _trayIcon.Text = "Unable to connect to HPSkyStatus";

            lblUsername.Text = "Username: Unknown";
            lblPlayerCount.Text = "Players: ?";
            lblServer.Text = "Server: Offline";
            lblLastUpdate.Text = $"Last Update: {DateTime.Now:T}";

            return;
        }

        _serverOnline = true;

        lblUsername.Text = $"Username: {status.Username}";
        lblPlayerCount.Text = $"Players: {status.SkyblockPlayers}";
        lblLastUpdate.Text = $"Last Update: {DateTime.Now:T}";

        if (status.SkyblockPlayers <= 25)
        {
            _trayIcon.Icon = _yellowIcon;
            _trayIcon.Text = $"SkyBlock Maintenance - {status.SkyblockPlayers} players";

            lblServer.Text = "Server: Maintenance";
        }
        else
        {
            _trayIcon.Icon = _greenIcon;
            _trayIcon.Text = $"SkyBlock Online - {status.SkyblockPlayers} players";

            lblServer.Text = "Server: Online";
        }
    }

    private async Task UpdatePlayers()
    {
        var players = await _playerWatchService.GetStatuses();

        lvPlayers.Items.Clear();

        foreach (var player in players)
        {
            var item = new ListViewItem(player.Username);

            item.SubItems.Add(player.Online ? "Online" : "Offline");

            item.SubItems.Add(
                player.Online
                    ? player.Mode
                    : "-");

            lvPlayers.Items.Add(item);
        }
    }
    private void grpStatus_Enter(object sender, EventArgs e)
    {

    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        btnRefresh.Enabled = false;

        await UpdateStatus();

        btnRefresh.Enabled = true;
    }

    private void lvPlayers_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private async void btnAddPlayer_Click(object sender, EventArgs e)
    {
        if (_clientSettings.Settings != null &&
            lvPlayers.Items.Count >= _clientSettings.Settings.MaxWatchedPlayers)
        {
            MessageBox.Show(
                $"You may only watch {_clientSettings.Settings.MaxWatchedPlayers} players.",
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        using var dialog = _serviceProvider.GetRequiredService<AddPlayerForm>();

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        var result = await _playerWatchService.AddPlayer(dialog.Username);

        if (!result.Success)
        {
            MessageBox.Show(
                result.Error,
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        await UpdatePlayers();
    }

    private async void btnRemovePlayer_Click(object sender, EventArgs e)
    {
        if (lvPlayers.SelectedItems.Count == 0)
        {
            MessageBox.Show(
                "Select a player first.",
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        var username = lvPlayers.SelectedItems[0].Text;

        var result = await _playerWatchService.RemovePlayer(username);

        if (!result.Success)
        {
            MessageBox.Show(
                result.Error,
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        await UpdatePlayers();
    }

    private void tabPage1_Click(object sender, EventArgs e)
    {

    }
}