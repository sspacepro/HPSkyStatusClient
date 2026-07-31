using HPSkyStatusClient.Configuration;
using HPSkyStatusClient.Forms;
using HPSkyStatusClient.Models;
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
    private readonly AuctionWatchService _auctionWatchService;
    private bool _serverOnline;
    private readonly IServiceProvider _serviceProvider;
    private readonly ApiErrorService _errorService;
    private readonly ClientSettingsApiService _clientSettings;
    public MainForm(
        StatusService statusService,
        PlayerWatchService playerWatchService,
        AuctionWatchService auctionWatchService,
        IServiceProvider serviceProvider,
        ApiErrorService errorService,
        ClientSettingsApiService clientSettings)
    {
        _statusService = statusService;
        _playerWatchService = playerWatchService;
        _auctionWatchService = auctionWatchService;
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
            await UpdateAuctions();
        };

        timer.Start();

        _ = Task.Run(async () =>
        {
            await _clientSettings.Refresh();
            await UpdateStatus();
            await UpdatePlayers();
            await UpdateAuctions();
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

    private async Task UpdateAuctions()
    {
        var auctions = await _auctionWatchService.GetWatches();

        lvAuctions.Items.Clear();

        foreach (var auction in auctions)
        {
            var item = new ListViewItem(
                auction.ItemTag);

            item.SubItems.Add(
                auction.Tier);

            item.SubItems.Add(
                auction.Stars?.ToString() ?? "-");

            item.SubItems.Add(
                auction.Recombobulated == true
                    ? "Yes"
                    : "-");

            item.SubItems.Add(
                auction.LastLowestBin.ToString("N0"));

            item.SubItems.Add(
                auction.NotifyBelow.ToString("N0"));

            item.Tag = auction;

            lvAuctions.Items.Add(item);
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

    private async void btnAddAuction_Click(object sender, EventArgs e)
    {
        using var dialog =
            _serviceProvider.GetRequiredService<AddAuctionForm>();

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        var result =
            await _auctionWatchService.AddWatch(dialog.Watch);

        if (!result.Success)
        {
            MessageBox.Show(
                result.Error,
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        await UpdateAuctions();
    }

    private async void btnRemoveAuction_Click(object sender, EventArgs e)
    {
        if (lvAuctions.SelectedItems.Count == 0)
        {
            MessageBox.Show(
                "Select an auction first.",
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        var auction =
            (AuctionWatch)lvAuctions.SelectedItems[0].Tag;

        var result =
            await _auctionWatchService.RemoveWatch(
                auction.WatchId);

        if (!result.Success)
        {
            MessageBox.Show(
                result.Error,
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        await UpdateAuctions();
    }

    private void lvAuctions_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void grpAuctions_Enter(object sender, EventArgs e)
    {

    }

    private void lvAuctions_DoubleClick(object sender, EventArgs e)
    {
        if (lvAuctions.SelectedItems.Count == 0)
            return;

        var auction =
            (AuctionWatch)lvAuctions.SelectedItems[0].Tag;

        var form =
            new AuctionDetailsForm(auction);

        form.ShowDialog();
    }
}