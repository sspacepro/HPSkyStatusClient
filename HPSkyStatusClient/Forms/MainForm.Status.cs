using HPSkyStatusClient.Services;

namespace HPSkyStatusClient;

public partial class MainForm
{
    private bool _serverOnline;
    private bool _serverMaintenance;
    private int _serverPlayerCount;
    private async Task UpdateStatus()
    {
        var status = await _statusService.GetStatus();

        if (status == null)
        {
            _serverOnline = false;
            _serverMaintenance = false;
            _serverPlayerCount = 0;
            UpdateTrayIconFromCurrentStatus();
            UpdateTrayIcon(
                online: false,
                maintenance: false,
                playerCount: 0);

            _trayIcon.Text =
                _auctionAlertActive
                    ? "Unable to connect - Auction Alert"
                    : "Unable to connect to HPSkyStatus";

            lblUsername.Text = "Username: Unknown";
            lblPlayerCount.Text = "Players: ?";
            lblServer.Text = "Server: Offline";
            _trayServerItem.Text = "SkyBlock: Offline";
            _trayPlayersItem.Text = "Players: ?";
            lblLastUpdate.Text = $"Last Update: {DateTime.Now:T}";

            return;
        }

        lblUsername.Text = $"Username: {status.Username}";
        lblPlayerCount.Text = $"Players: {status.SkyblockPlayers}";
        lblLastUpdate.Text = $"Last Update: {DateTime.Now:T}";
        _serverPlayerCount = status.SkyblockPlayers;
        if (status.SkyblockPlayers <= 0)
        {
            _serverOnline = false;
            _serverMaintenance = false;
            UpdateTrayIcon(
                online: false,
                maintenance: false,
                playerCount: 0);

            lblServer.Text = "Server: Can not connect";
            lblPlayerCount.Text = "Players: N/A";

            _trayServerItem.Text = "SkyBlock: Offline";
            _trayPlayersItem.Text = "Players: N/A";
        }
        else if (status.SkyblockPlayers <= 25)
        {
            _serverOnline = true;
            _serverMaintenance = true;
            UpdateTrayIcon(
                online: true,
                maintenance: true,
                playerCount: status.SkyblockPlayers);

            lblServer.Text = "Server: Maintenance";

            _trayServerItem.Text = "SkyBlock: Maintenance";
            _trayPlayersItem.Text =
                $"Players: {status.SkyblockPlayers:N0}";
        }
        else
        {
            _serverOnline = true;
            _serverMaintenance = false;
            UpdateTrayIcon(
                online: true,
                maintenance: false,
                playerCount: status.SkyblockPlayers);

            lblServer.Text = "Server: Online";

            _trayServerItem.Text = "SkyBlock: Online";
            _trayPlayersItem.Text =
                $"Players: {status.SkyblockPlayers:N0}";
        }
        UpdateTrayIconFromCurrentStatus();

    }
    private void UpdateTrayIconFromCurrentStatus()
    {
        UpdateTrayIcon(
            _serverOnline,
            _serverMaintenance,
            _serverPlayerCount);
    }
    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        btnRefresh.Enabled = false;
        await UpdateStatus();

        btnRefresh.Enabled = true;
    }
    
}