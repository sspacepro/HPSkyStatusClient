using HPSkyStatusClient.Models;
using HPSkyStatusClient.Services;

namespace HPSkyStatusClient.Forms;

public partial class AddAuctionForm : Form
{
    public AuctionWatch Watch { get; private set; } = new();

    public AddAuctionForm()
    {
        InitializeComponent();

        cmbTier.Items.AddRange(new[]
        {
            "COMMON",
            "UNCOMMON",
            "RARE",
            "EPIC",
            "LEGENDARY",
            "MYTHIC"
        });

        cmbTier.SelectedIndex = -1;
        cmbTier.Text = "";
    }

    private void btnAdd_Click_1(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtItem.Text))
        {
            MessageBox.Show(
                "Enter an item name.");

            return;
        }
        if (numPetLevel.Value > 0 &&
    string.IsNullOrWhiteSpace(cmbTier.Text))
        {
            MessageBox.Show(
                "Please select a pet rarity when entering a pet level.",
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }
        Watch = new AuctionWatch
        {
            ItemTag = txtItem.Text
                .Trim()
                .Replace(" ", "_")
                .ToUpper(),

            Tier = string.IsNullOrWhiteSpace(cmbTier.Text)
                ? null
                : cmbTier.Text,

            Stars = numStars.Value > 0
                ? (int)numStars.Value
                : null,

            Recombobulated = chkRecomb.Checked
                ? true
                : null,

            PetXp = numPetLevel.Value > 0
                ? (int)PetLevelCalculator.LevelToXp(
                    cmbTier.Text,
                    (int)numPetLevel.Value)
                : null,

            NotifyBelow = (long)numNotify.Value
        };

        DialogResult = DialogResult.OK;
        Close();


    }



}