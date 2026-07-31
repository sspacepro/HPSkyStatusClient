using HPSkyStatusClient.Models;

namespace HPSkyStatusClient.Forms;

public partial class AuctionDetailsForm : Form
{
    private readonly AuctionWatch _auction;

    public AuctionDetailsForm(
        AuctionWatch auction)
    {
        InitializeComponent();

        _auction = auction;

        LoadAuction();
    }

    private void LoadAuction()
    {
        lblItemName.Text =
            _auction.DisplayItemName;

        lblLowestBin.Text =
            $"Lowest BIN: {_auction.LastLowestBin:N0}";

        lblNotifyBelow.Text =
            $"Notify Below: {_auction.NotifyBelow:N0}";

        txtLore.Text =
            _auction.ItemLore;
    }
}