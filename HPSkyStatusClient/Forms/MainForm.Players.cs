
/*
 using HPSkyStatusClient.Forms;

using Microsoft.Extensions.DependencyInjection;

namespace HPSkyStatusClient;

public partial class MainForm
{
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

}
*/