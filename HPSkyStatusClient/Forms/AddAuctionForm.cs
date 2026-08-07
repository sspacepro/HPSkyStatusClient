using HPSkyStatusClient.Models;
using HPSkyStatusClient.Services;

namespace HPSkyStatusClient.Forms;

public partial class AddAuctionForm : Form
{
    public AuctionWatch Watch { get; private set; } = new();
    private bool _updatingSelection;
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
            ItemTag = SelectedItem != null
                ? SelectedItem.Id
                : txtItem.Text
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
    private readonly ItemCacheService _items;

    public AddAuctionForm(
        ItemCacheService items)
    {
        InitializeComponent();

        _items = items;

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

        lstItems.DisplayMember = nameof(HypixelItem.DisplayName);
    }

    private void txtItem_TextChanged_1(
    object sender,
    EventArgs e)
    {
        if (_updatingSelection)
            return;
        SelectedItem = null;

        lstItems.Items.Clear();


        foreach (var item in _items.Search(txtItem.Text))
        {
            lstItems.Items.Add(item);
        }

    }
    private HypixelItem? SelectedItem;
    private void lstItems_SelectedIndexChanged_1(
    object sender,
    EventArgs e)
    {
        SelectedItem =
            lstItems.SelectedItem as HypixelItem;


        if (SelectedItem == null)
            return;

        _updatingSelection = true;
        txtItem.Text = SelectedItem.DisplayName;

        _updatingSelection = false;
        UpdateItemOptions();
    }
    private void UpdateItemOptions()
    {
        if (SelectedItem == null)
            return;


        bool isPet =
            SelectedItem.Id.EndsWith(
                "_PET",
                StringComparison.OrdinalIgnoreCase);


        // PET
        if (isPet)
        {
            numStars.Visible = false;
            lblStars.Visible = false;

            numPetLevel.Visible = true;
            lblPetLevel.Visible = true;

            cmbTier.Visible = true;
            lblTier.Visible = true;
        }
        else
        {
            numPetLevel.Visible = false;
            lblPetLevel.Visible = false;

            cmbTier.Visible = false;
            lblTier.Visible = false;

            numStars.Visible = true;
            lblStars.Visible = true;
        }


        chkRecomb.Visible =
            SelectedItem.CanRecombobulate != false;


    }




}