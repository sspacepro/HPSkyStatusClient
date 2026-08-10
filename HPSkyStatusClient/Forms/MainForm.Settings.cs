using HPSkyStatusClient.Models;
using HPSkyStatusClient.Services;
using System.Net.Http.Json;

namespace HPSkyStatusClient;

public partial class MainForm
{
    private void LoadClientSettings()
    {
        txtServerUrl.Text = _localSettings.Settings.ServerUrl;
        txtServerUrl.PlaceholderText = ClientSettingsService.DefaultServerUrl;

        numNotificationHistory.Value = _preferences.Preferences.NotificationHistoryMinutes;

        chkAuctionNotifications.Checked = _preferences.Preferences.AuctionNotifications;

        chkStartupNotificationHistory.Checked = _preferences.Preferences.StartupNotificationHistory;

        chkMinimizeToTray.Checked = _preferences.Preferences.MinimizeToTray;
    }

    private void LoadServerSettings()
    {
        if (_clientSettings.Settings == null)
        {
            lblMaxAuctions.Text = "Max Auctions: Unknown";
            return;
        }

        lblMaxAuctions.Text =
            $"Max Auctions: {_clientSettings.Settings.MaxAuctionWatchesPerClient}";
    }

    private void btnSaveSettings_Click(object sender, EventArgs e)
    {
        _localSettings.Settings.ServerUrl = txtServerUrl.Text.Trim();
        _localSettings.Save();

        _preferences.Preferences.NotificationHistoryMinutes = (int)numNotificationHistory.Value;
        _preferences.Preferences.AuctionNotifications = chkAuctionNotifications.Checked;
        _preferences.Preferences.StartupNotificationHistory = chkStartupNotificationHistory.Checked;
        _preferences.Preferences.MinimizeToTray = chkMinimizeToTray.Checked;
        _preferences.Save();

        MessageBox.Show(
            "Settings saved.",
            "HPSkyStatus",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    private async void btnReloadSettings_Click(object sender, EventArgs e)
    {
        try
        {
            _preferences.Load();
            await _clientSettings.Refresh();

            LoadClientSettings();
            LoadServerSettings();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Failed to reload settings: {ex.Message}",
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }

    private async void btnHealth_Click(object sender, EventArgs e)
    {
        try
        {
            var response = await _apiService.GetAsync("/api/v1/health");

            if (response == null || !response.IsSuccessStatusCode)
            {
                MessageBox.Show("Unable to contact server.");
                return;
            }

            var health = await response.Content.ReadFromJsonAsync<HealthResponse>();

            if (health == null)
            {
                MessageBox.Show("Invalid response.");
                return;
            }

            MessageBox.Show(
                $@"Status: {health.Status}

Uptime: {health.UptimeSeconds:N0} seconds
Hypixel Online: {health.HypixelOnline}
SkyBlock Players: {health.SkyBlockPlayers:N0}
Cached Auctions: {health.CachedAuctions:N0}
Cached Items: {health.CachedItems:N0}
Queued Notifications: {health.QueuedNotifications:N0}",
                "Health");
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Failed to retrieve health: {ex.Message}",
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}