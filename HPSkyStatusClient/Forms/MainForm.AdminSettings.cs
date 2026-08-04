using HPSkyStatusClient.Services;

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
            tabMain.TabPages.Insert(4, pgAdmin);
        }

        await LoadAdminSettings();
        //await RefreshUsers();
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

    private void numPurgeInactive_KeyDown(object sender, KeyEventArgs e)
    {

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
}