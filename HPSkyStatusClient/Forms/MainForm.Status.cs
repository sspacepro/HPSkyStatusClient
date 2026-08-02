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
        }
        else
        {
            _trayIcon.Icon = _greenIcon;
            _trayIcon.Text = $"SkyBlock Online - {status.SkyblockPlayers} players";

            lblServer.Text = "Server: Online";
        }
    }
    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        btnRefresh.Enabled = false;
        await UpdateStatus();

        btnRefresh.Enabled = true;
    }
    private async Task CheckNotifications(bool startup = false)
    {
        var notifications =
            await _notificationApiService.GetNotifications();

        foreach (var notification in notifications)
        {
            if (startup)
            {
                var age = DateTime.UtcNow - notification.Created;

                if (age.TotalMinutes >
                    _localSettings.Settings.NotificationHistoryMinutes)
                {
                    continue;
                }
            }

            var message = notification.Message;

            if (startup)
            {
                message +=
                    $" ({_notificationTime.Format(notification.Created)})";
            }

            _notifications.Show(
                notification.Title,
                message);
        }
    }
}