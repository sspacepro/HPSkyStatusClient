using HPSkyStatusClient.Models;

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

            PetXp = numPetXp.Value > 0
                ? (int)numPetXp.Value
                : null,

            NotifyBelow = (long)numNotify.Value
        };

        DialogResult = DialogResult.OK;
        Close();


    }

    private void AddAuctionForm_Load(object sender, EventArgs e)
    {

    }


}