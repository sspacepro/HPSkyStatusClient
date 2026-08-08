using HPSkyStatusClient.Forms;
using HPSkyStatusClient.Models;
using HPSkyStatusClient.Services;

namespace HPSkyStatusClient;

public partial class MainForm
{
    private void UpdateTrayAuctions(List<AuctionWatch> auctions)
    {
        foreach (var item in _trayAuctionItems)
            _trayIcon.ContextMenuStrip!.Items.Remove(item);

        _trayAuctionItems.Clear();

        var menu = _trayIcon.ContextMenuStrip;

        if (menu == null)
            return;

        int insertIndex =
            menu.Items.IndexOf(_trayAuctionSeparator) + 1;

        foreach (var auction in auctions.Take(5))
        {
            string text =
                $"{auction.DisplayItemName} - {auction.LastLowestBin:N0}";

            if (auction.LastLowestBin <= auction.NotifyBelow && auction.LastLowestBin > 0)
                text = "⚠ " + text;

            var tier =
                auction.Tier ??
                _itemCache.GetTier(auction.ItemTag);

            var item = new ToolStripMenuItem(text)
            {
                ForeColor = TrayColorService.GetColor(
                    tier,
                    auction.Recombobulated == true)
            };

            item.Click += (_, _) =>
            {
                using var details = new AuctionDetailsForm(auction);
                details.ShowDialog();
            };

            _trayAuctionItems.Add(item);

            menu.Items.Insert(
                insertIndex++,
                item);
        }

        if (auctions.Count > 5)
        {
            var more = new ToolStripMenuItem(
                $"...and {auctions.Count - 5} more");

            more.Click += (_, _) =>
            {
                Show();
                WindowState = FormWindowState.Normal;

                tabMain.SelectedTab = pgAuctions;
            };

            _trayAuctionItems.Add(more);

            menu.Items.Insert(
                insertIndex,
                more);
        }
    }
    private void UpdateTrayUpdatedTime()
    {
        _trayUpdatedItem.Text =
            $"Updated: {DateTime.Now:t}";
    }
}