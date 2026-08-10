
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

            lblUsername.Text = "Username: Unknown";
            lblPlayerCount.Text = "Players: ?";
            lblServer.Text = "Server: Offline";
            lblLastUpdate.Text = $"Last Update: {DateTime.Now:T}";
            _trayServerItem.Text = "SkyBlock: Offline";
            _trayPlayersItem.Text = "Players: ?";

            UpdateTrayIconFromCurrentStatus();
            return;
        }

        lblUsername.Text = $"Username: {status.Username}";
        lblLastUpdate.Text = $"Last Update: {DateTime.Now:T}";
        _serverPlayerCount = status.SkyblockPlayers;

        if (status.SkyblockPlayers <= 0)
        {
            _serverOnline = false;
            _serverMaintenance = false;

            lblServer.Text = "Server: Can not connect";
            lblPlayerCount.Text = "Players: N/A";
            _trayServerItem.Text = "SkyBlock: Offline";
            _trayPlayersItem.Text = "Players: N/A";
        }
        else if (status.SkyblockPlayers <= 25)
        {
            _serverOnline = true;
            _serverMaintenance = true;

            lblServer.Text = "Server: Maintenance";
            lblPlayerCount.Text = $"Players: {status.SkyblockPlayers:N0}";
            _trayServerItem.Text = "SkyBlock: Maintenance";
            _trayPlayersItem.Text = $"Players: {status.SkyblockPlayers:N0}";
        }
        else
        {
            _serverOnline = true;
            _serverMaintenance = false;

            lblServer.Text = "Server: Online";
            lblPlayerCount.Text = $"Players: {status.SkyblockPlayers:N0}";
            _trayServerItem.Text = "SkyBlock: Online";
            _trayPlayersItem.Text = $"Players: {status.SkyblockPlayers:N0}";
        }

        UpdateTrayIconFromCurrentStatus();
    }

    private void UpdateTrayIconFromCurrentStatus()
    {
        UpdateTrayIcon(_serverOnline, _serverMaintenance, _serverPlayerCount);
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        btnRefresh.Enabled = false;
        try
        {
            await UpdateStatus();
        }
        finally
        {
            btnRefresh.Enabled = true;
        }
    }
}