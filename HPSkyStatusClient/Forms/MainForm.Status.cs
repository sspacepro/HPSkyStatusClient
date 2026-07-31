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

}