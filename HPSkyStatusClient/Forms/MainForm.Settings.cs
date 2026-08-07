using HPSkyStatusClient.Services;

namespace HPSkyStatusClient;

public partial class MainForm
{
    private void LoadClientSettings()
    {
        txtServerUrl.Text =
            _localSettings.Settings.ServerUrl;

        txtServerUrl.PlaceholderText =
    ClientSettingsService.DefaultServerUrl;

        numNotificationHistory.Value =
            _preferences.Preferences.NotificationHistoryMinutes;

        chkPlayerNotifications.Checked =
            _preferences.Preferences.PlayerNotifications;

        chkAuctionNotifications.Checked =
            _preferences.Preferences.AuctionNotifications;

        chkStartupNotificationHistory.Checked =
            _preferences.Preferences.StartupNotificationHistory;

        chkMinimizeToTray.Checked =
            _preferences.Preferences.MinimizeToTray;
    }

    private void LoadServerSettings()
    {
        if (_clientSettings.Settings == null)
        {
            lblMaxPlayers.Text = "Max Players: Unknown";
            lblMaxAuctions.Text = "Max Auctions: Unknown";
            return;
        }

        lblMaxPlayers.Text =
            $"Max Players: {_clientSettings.Settings.MaxWatchedPlayers}";

        lblMaxAuctions.Text =
            $"Max Auctions: {_clientSettings.Settings.MaxAuctionWatchesPerClient}";
    }
    private void btnSaveSettings_Click(object sender, EventArgs e)
    {
        _localSettings.Settings.ServerUrl =
    txtServerUrl.Text.Trim();

        _localSettings.Save();

        _preferences.Preferences.NotificationHistoryMinutes =
            (int)numNotificationHistory.Value;

        _preferences.Preferences.PlayerNotifications =
            chkPlayerNotifications.Checked;

        _preferences.Preferences.AuctionNotifications =
            chkAuctionNotifications.Checked;

        _preferences.Preferences.StartupNotificationHistory =
            chkStartupNotificationHistory.Checked;

        _preferences.Preferences.MinimizeToTray =
            chkMinimizeToTray.Checked;

        _preferences.Save();

        MessageBox.Show(
            "Settings saved.",
            "HPSkyStatus",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
    private async void btnReloadSettings_Click(object sender, EventArgs e)
    {
        _preferences.Load();

        await _clientSettings.Refresh();

        LoadClientSettings();
        LoadServerSettings();
    }
}