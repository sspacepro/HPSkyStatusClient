using HPSkyStatusClient.Models;
using HPSkyStatusClient.Services;
using System.Drawing.Text;

namespace HPSkyStatusClient.Forms;

public partial class AddAuctionForm : Form
{
    private readonly ItemCacheService _items;
    private HypixelItem? _selectedItem;
    private bool _updatingSelection;

    public AuctionWatch Watch { get; private set; } = new();


    public AddAuctionForm(ItemCacheService items)
    {
        InitializeComponent();
        var font = CustomFontService.LoadFont("minecraft_font.ttf", 7.5f);
        ApplyFont(this, font);
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

    private void btnAdd_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtItem.Text))
        {
            MessageBox.Show("Enter an item name.");
            return;
        }

        if (numPetLevel.Value > 0 && string.IsNullOrWhiteSpace(cmbTier.Text))
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
            ItemTag = _selectedItem != null
                ? _selectedItem.Id
                : txtItem.Text.Trim().Replace(" ", "_").ToUpper(),

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
                ? (int)PetLevelCalculator.LevelToXp(cmbTier.Text, (int)numPetLevel.Value)
                : null,

            NotifyBelow = (long)numNotify.Value
        };

        DialogResult = DialogResult.OK;
        Close();
    }

    private void txtItem_TextChanged(object sender, EventArgs e)
    {
        if (_updatingSelection)
            return;

        _selectedItem = null;

        lstItems.Items.Clear();

        foreach (var item in _items.Search(txtItem.Text))
        {
            lstItems.Items.Add(item);
        }
    }

    private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
    {
        _selectedItem = lstItems.SelectedItem as HypixelItem;

        if (_selectedItem == null)
            return;

        _updatingSelection = true;
        txtItem.Text = _selectedItem.DisplayName;
        _updatingSelection = false;

        UpdateItemOptions();
    }

    private void UpdateItemOptions()
    {
        if (_selectedItem == null)
            return;

        bool isPet = _selectedItem.Id.EndsWith("_PET", StringComparison.OrdinalIgnoreCase);

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

        chkRecomb.Visible = _selectedItem.CanRecombobulate != false;
    }
    private static void ApplyFont(Control control, Font font)
    {
        control.Font = font;

        foreach (Control child in control.Controls)
            ApplyFont(child, font);
    }


}