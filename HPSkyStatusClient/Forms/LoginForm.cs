using HPSkyStatusClient.Services;

namespace HPSkyStatusClient.Forms;

public partial class LoginForm : Form
{
    private readonly AuthenticationService _auth;

    public LoginForm(AuthenticationService auth)
    {
        InitializeComponent();
        _auth = auth;
    }

    private async void btnRegister_Click_1(object sender, EventArgs e)
    {
        string username = txtUsername.Text.Trim();

        if (string.IsNullOrWhiteSpace(username))
        {
            MessageBox.Show("Enter a username.");
            return;
        }

        btnRegister.Enabled = false;

        bool success = await _auth.Register(username);

        if (success)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        else
        {
            MessageBox.Show("Registration failed.");
            btnRegister.Enabled = true;
        }
    }



    private void LoginForm_Load(object sender, EventArgs e)
    {

    }
}