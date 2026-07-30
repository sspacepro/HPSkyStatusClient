using System;
using System.Windows.Forms;

namespace HPSkyStatusClient.Forms;

public partial class AddPlayerForm : Form
{
    public AddPlayerForm()
    {
        InitializeComponent();
    }

    public string Username => txtUsername.Text.Trim();

    private void btnAdd_Click_1(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtUsername.Text))
        {
            MessageBox.Show(
                "Please enter a Minecraft username.",
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        DialogResult = DialogResult.OK;
        Close();
    }


}