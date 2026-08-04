using HPSkyStatusClient.Services;

namespace HPSkyStatusClient;

public partial class MainForm
{

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
            _trayServerItem.Text = "SkyBlock: Offline";
            _trayPlayersItem.Text = "Players: ?";
            lblLastUpdate.Text = $"Last Update: {DateTime.Now:T}";

            return;
        }

        _serverOnline = true;

        lblUsername.Text = $"Username: {status.Username}";
        lblPlayerCount.Text = $"Players: {status.SkyblockPlayers}";
        lblLastUpdate.Text = $"Last Update: {DateTime.Now:T}";
        if (status.SkyblockPlayers <= 0)
        {
            _trayIcon.Icon = _redIcon;
            _trayIcon.Text = "Unable to connect to Hypixel";

            lblServer.Text = "Server: Can not connect";
            lblPlayerCount.Text = "Players: N/A";
        }
        else if (status.SkyblockPlayers <= 25)
        {
            _trayIcon.Icon = _yellowIcon;
            _trayIcon.Text = $"SkyBlock Maintenance - {status.SkyblockPlayers} players";

            lblServer.Text = "Server: Maintenance";
            _trayServerItem.Text = "SkyBlock: Maintenance";
            _trayPlayersItem.Text =
                $"Players: {status.SkyblockPlayers:N0}";
        }
        else
        {
            _trayIcon.Icon = _greenIcon;
            _trayIcon.Text = $"SkyBlock Online - {status.SkyblockPlayers} players";

            lblServer.Text = "Server: Online";
            _trayServerItem.Text = "SkyBlock: Online";
            _trayPlayersItem.Text =
                $"Players: {status.SkyblockPlayers:N0}";
        }
    }
    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        btnRefresh.Enabled = false;
        await UpdateStatus();

        btnRefresh.Enabled = true;
    }
    
}