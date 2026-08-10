using HPSkyStatusClient.Models;
using HPSkyStatusClient.Services;
using System.Net.Http.Json;

namespace HPSkyStatusClient;

public partial class MainForm
{


    private async void txtAdminKey_KeyDown(object sender, KeyEventArgs e)
    {


        if (e.KeyCode != Keys.Enter)
            return;

        _adminApi.SetKey(txtAdminKey.Text);

        var response =
            await _adminApi.Get("/api/admin/validate");

        if (response == null || !response.IsSuccessStatusCode)
        {
            MessageBox.Show("Invalid admin key.");
            return;
        }

        if (!tabMain.TabPages.Contains(pgAdmin))
        {
            tabMain.TabPages.Insert(2, pgAdmin);
        }

        await LoadAdminSettings();
        await RefreshUsers();
    }

    private async Task LoadAdminSettings()
    {
        munHypixelUpdateInterval.Text =
            (await _adminApi.GetString(
                "/api/admin/settings/hypixel-update-interval-seconds")) ?? "";

        numAuctionCacheRefresh.Text =
            (await _adminApi.GetString(
                "/api/admin/settings/auction-cache-refresh")) ?? "";

        numAuctionCheckInterval.Text =
            (await _adminApi.GetString(
                "/api/admin/settings/auction-check-interval")) ?? "";

        numMaxAuctionWatches.Text =
            (await _adminApi.GetString(
                "/api/admin/settings/max-auction-watches")) ?? "";

        numMaxPlayerRequestsPerMinute.Text =
            (await _adminApi.GetString(
                "/api/admin/settings/max-requests-per-minute")) ?? "";

        numWatchCleanupInterval.Text =
            (await _adminApi.GetString(
                "/api/admin/settings/watch-cleanup-interval-minutes")) ?? "";

        numWatchExpiration.Text =
            (await _adminApi.GetString(
                "/api/admin/settings/watch-expiration-days")) ?? "";
        numItemCacheUpdatteMinutes.Text =
            (await _adminApi.GetString(
                "/api/admin/settings/item-cache-update-minutes")) ?? "";
    }

    private async Task SaveAdminSetting(
    string endpoint)
    {
        var response = await _adminApi.Post(endpoint);

        if (response == null || !response.IsSuccessStatusCode)
        {
            MessageBox.Show(
                "Failed to save setting.");

            return;
        }
        await LoadAdminSettings();
    }

    private async void munHypixelUpdateInterval_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
            return;

        await SaveAdminSetting(
            $"/api/admin/settings/hypixel-update-interval-seconds/{munHypixelUpdateInterval.Text}");
    }

    private async void numAuctionCacheRefresh_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
            return;

        await SaveAdminSetting(
            $"/api/admin/settings/auction-cache-refresh/{numAuctionCacheRefresh.Text}");
    }

    private async void numAuctionCheckInterval_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
            return;

        await SaveAdminSetting(
            $"/api/admin/settings/auction-check-interval/{numAuctionCheckInterval.Text}");
    }

    private async void numMaxAuctionWatches_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
            return;

        await SaveAdminSetting(
            $"/api/admin/settings/max-auction-watches/{numMaxAuctionWatches.Text}");
    }

    private async void numMaxPlayerRequestsPerMinute_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
            return;

        await SaveAdminSetting(
            $"/api/admin/settings/max-requests-per-minute/{numMaxPlayerRequestsPerMinute.Text}");
    }

    private async void numWatchCleanupInterval_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
            return;

        await SaveAdminSetting(
            $"/api/admin/settings/watch-cleanup-interval-minutes/{numWatchCleanupInterval.Text}");
    }

    private async void numWatchExpiration_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
            return;

        await SaveAdminSetting(
            $"/api/admin/settings/watch-expiration-days/{numWatchExpiration.Text}");
    }

    private async void numItemCacheUpdatteMinutes_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
            return;
        await SaveAdminSetting(
            $"/api/admin/settings/item-cache-update-minutes/{numItemCacheUpdatteMinutes.Text}");
    }

    private async void txtUpdateApiKey_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
            return;

        var response = await _adminApi.Post(
            $"/api/admin/settings/HypixelApiKey?value={Uri.EscapeDataString(txtUpdateApiKey.Text)}");

        if (response == null || !response.IsSuccessStatusCode)
        {
            MessageBox.Show(
                "Failed to update API key.");

            return;
        }

        txtUpdateApiKey.Clear();

        MessageBox.Show(
            "Hypixel API key updated.");
    }
    private async Task RefreshUsers()
    {
        lvUsers.Items.Clear();

        var users =
            await _adminApi.GetUsers();

        foreach (var user in users)
        {
            var item =
                new ListViewItem(user.Username);

            item.SubItems.Add(
                user.Blocked
                    ? "Yes"
                    : "No");

            item.SubItems.Add(
                user.LastSeen == default
                    ? "-"
                    : user.LastSeen.ToLocalTime()
                        .ToString("g"));

            item.Tag = user;

            lvUsers.Items.Add(item);
        }
    }
    private async void btnRefreshUsers_Click(
        object sender,
        EventArgs e)
    {
        await RefreshUsers();
    }

    private async void btnBlock_Click(
        object sender,
        EventArgs e)
    {
        if (lvUsers.SelectedItems.Count == 0)
            return;
        var user =
            lvUsers.SelectedItems[0].Tag as AdminUser;

        if (user == null)
            return;
        if (user.Username.Equals(
        _localSettings.Settings.Username,
        StringComparison.OrdinalIgnoreCase))
        {
            MessageBox.Show(
                "You cannot block yourself.");

            return;
        }

        if (await _adminApi.BlockUser(user.Username))
        {
            await RefreshUsers();
        }
        else
        {
            MessageBox.Show(
                "Failed to block user.");
        }
    }
    private async void btnUnblock_Click(
    object sender,
    EventArgs e)
    {
        if (lvUsers.SelectedItems.Count == 0)
            return;

        var user =
            lvUsers.SelectedItems[0].Tag as AdminUser;

        if (user == null)
            return;

        if (await _adminApi.UnblockUser(user.Username))
        {
            await RefreshUsers();
        }
        else
        {
            MessageBox.Show(
                "Failed to unblock user.");
        }
    }
    private async void btnDelete_Click(
    object sender,
    EventArgs e)
    {
        if (lvUsers.SelectedItems.Count == 0)
            return;

        var user =
            lvUsers.SelectedItems[0].Tag as AdminUser;

        if (user == null)
            return;

        if (user.Username.Equals(
                _localSettings.Settings.Username,
                StringComparison.OrdinalIgnoreCase))
        {
            MessageBox.Show(
                "You cannot delete yourself.");

            return;
        }

        var result = MessageBox.Show(
            $"Delete '{user.Username}'?",
            "Delete User",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result != DialogResult.Yes)
            return;

        if (await _adminApi.DeleteUser(user.ClientId))
        {
            await RefreshUsers();
        }
        else
        {
            MessageBox.Show(
                "Failed to delete user.");
        }
    }
    private async void btnPurgeInactive_Click(
        object sender,
        EventArgs e)
    {
        int days = (int)numPurgeInactive.Value;

        var removed =
            await _adminApi.PurgeInactiveUsers(days);

        if (removed == null)
        {
            MessageBox.Show(
                "Failed to purge users.");

            return;
        }

        MessageBox.Show(
            $"Removed {removed} inactive users.");

        await RefreshUsers();
    }
    private async void btnShutdownServer_Click(
    object sender,
    EventArgs e)
    {
        var result =
            MessageBox.Show(
                "Are you sure you want to shut down the server?",
                "Shutdown Server",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

        if (result != DialogResult.Yes)
            return;

        if (await _adminApi.ShutdownServer())
        {
            MessageBox.Show(
                "The server is shutting down.");
        }
        else
        {
            MessageBox.Show(
                "Failed to shut down the server.");
        }
    }
    private void btnBackup_Click(object sender, EventArgs e)
    {
        var backup = _adminApi.PostBackup();
        if (backup == null)
        {
            MessageBox.Show(
                "Failed to create backup.");
            return;
        }
        else
        {
            MessageBox.Show(
                "Backup created successfully.");
        }
    }
    private async void btnStatus_Click(object sender, EventArgs e)
    {
        var status = await _adminApi.GetStatus();

        if (status == null)
        {
            MessageBox.Show("Unable to retrieve server status.");
            return;
        }

        MessageBox.Show(
    $@"Status: {status.Status}

Users: {status.Users}
Uptime: {status.UptimeSeconds:N0} seconds
Hypixel Online: {status.HypixelOnline}
SkyBlock Players: {status.SkyBlockPlayers:N0}
Cached Auctions: {status.CachedAuctions:N0}
Cached Items: {status.CachedItems:N0}
Queued Notifications: {status.QueuedNotifications:N0}",
        "Server Status",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
    }
    private async void btnSendNotification_Click(
    object sender,
    EventArgs e)
    {
        string title = txtNotificationTitle.Text.Trim();
        string message = txtNotificationMessage.Text.Trim();

        if (string.IsNullOrWhiteSpace(title))
        {
            MessageBox.Show(
                "Please enter a notification title.",
                "Notification");

            return;
        }

        if (string.IsNullOrWhiteSpace(message))
        {
            MessageBox.Show(
                "Please enter a notification message.",
                "Notification");

            return;
        }

        List<string>? clientIds = null;

        if (radNotificationSelected.Checked)
        {
            clientIds = lvUsers.SelectedItems
                .Cast<ListViewItem>()
                .Select(item => item.Tag as AdminUser)
                .Where(user => user != null)
                .Select(user => user!.ClientId)
                .ToList();

            if (clientIds.Count == 0)
            {
                MessageBox.Show(
                    "Select at least one user.",
                    "Notification");

                return;
            }
        }

        var success =
            await _adminApi.SendNotification(
                title,
                message,
                clientIds);

        if (!success)
        {
            MessageBox.Show(
                "Failed to send notification.",
                "Notification",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        MessageBox.Show(
            clientIds == null
                ? "Notification sent to everyone."
                : $"Notification sent to {clientIds.Count} user(s).",
            "Notification",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        txtNotificationTitle.Clear();
        txtNotificationMessage.Clear();
    }
}