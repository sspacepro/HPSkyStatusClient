using HPSkyStatusClient.Models;
using HPSkyStatusClient.Services;

namespace HPSkyStatusClient.Forms;

public partial class AuctionDetailsForm : Form
{
    private readonly AuctionWatch _auction;

    public AuctionDetailsForm(
        AuctionWatch auction)
    {
        var font = CustomFontService.LoadFont("minecraft_font.ttf", 7.5f);
        ApplyFont(this, font);
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

        MinecraftTextRenderer.Render(
            txtLore,
            _auction.ItemLore);
    }
    private static void ApplyFont(Control control, Font font)
    {
        control.Font = font;

        foreach (Control child in control.Controls)
            ApplyFont(child, font);
    }
}