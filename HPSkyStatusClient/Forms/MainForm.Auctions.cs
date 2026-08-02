
using HPSkyStatusClient.Forms;
using HPSkyStatusClient.Models;
using HPSkyStatusClient.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HPSkyStatusClient;

public partial class MainForm
{
    private async Task UpdateAuctions()
    {
        var auctions = await _auctionWatchService.GetWatches();

        lvAuctions.Items.Clear();

        foreach (var auction in auctions)
        {
            var item = new ListViewItem(
                auction.ItemTag);

            item.SubItems.Add(
                auction.Tier);

            item.SubItems.Add(
                auction.PetXp.HasValue
                    ? PetLevelCalculator
                        .XpToLevel(
                            auction.Tier!,
                            auction.PetXp.Value)
                        .ToString()
                    : "-");

            item.SubItems.Add(
                auction.Stars?.ToString() ?? "-");

            item.SubItems.Add(
                auction.Recombobulated == true
                    ? "Yes"
                    : "-");

            item.SubItems.Add(
                auction.LastLowestBin.ToString("N0"));

            item.SubItems.Add(
                auction.NotifyBelow.ToString("N0"));


            item.Tag = auction;

            lvAuctions.Items.Add(item);
        }
    }

    private async void btnAddAuction_Click(object sender, EventArgs e)
    {
        if (_clientSettings.Settings != null &&
    lvAuctions.Items.Count >= _clientSettings.Settings.MaxAuctionWatchesPerClient)
        {
            MessageBox.Show(
                $"You may only watch {_clientSettings.Settings.MaxAuctionWatchesPerClient} auctions.",
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }


        using var dialog =
            _serviceProvider.GetRequiredService<AddAuctionForm>();

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        var result =
            await _auctionWatchService.AddWatch(dialog.Watch);

        if (!result.Success)
        {
            MessageBox.Show(
                result.Error,
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        await UpdateAuctions();
    }

    private async void btnRemoveAuction_Click(object sender, EventArgs e)
    {
        if (lvAuctions.SelectedItems.Count == 0)
        {
            MessageBox.Show(
                "Select an auction first.",
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        var auction = lvAuctions.SelectedItems[0].Tag as AuctionWatch;

        if (auction == null)
            return;

        var result =
            await _auctionWatchService.RemoveWatch(
                auction.WatchId);

        if (!result.Success)
        {
            MessageBox.Show(
                result.Error,
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        await UpdateAuctions();
    }

    private void lvAuctions_DoubleClick(object sender, EventArgs e)
    {
        if (lvAuctions.SelectedItems.Count == 0)
            return;

        var auction = lvAuctions.SelectedItems[0].Tag as AuctionWatch;

        if (auction == null)
            return;

        var form =
            new AuctionDetailsForm(auction);

        form.ShowDialog();
    }
}