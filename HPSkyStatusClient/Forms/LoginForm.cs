using HPSkyStatusClient.Services;

namespace HPSkyStatusClient.Forms;


public partial class LoginForm : Form
{
    private readonly AuthenticationService _auth;
    private readonly AdminApiService _adminApi;
    public bool AdminAuthenticated { get; private set; }

    public LoginForm(AuthenticationService auth, AdminApiService adminApi)
    {
        InitializeComponent();
        _auth = auth;
        _adminApi = adminApi;
    }

    private async void btnRegister_Click(object sender, EventArgs e)
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
    private async void txtAdminKey1_KeyDown(
        object sender,
        KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter)
            return;

        string key = txtAdminKey.Text.Trim();

        if (string.IsNullOrWhiteSpace(key))
            return;

        txtAdminKey.Enabled = false;

        try
        {
            _adminApi.SetKey(key);

            var response =
                await _adminApi.Get("/api/admin/validate");

            if (response == null ||
                !response.IsSuccessStatusCode)
            {
                MessageBox.Show(
                    "Invalid admin key.",
                    "HPSkyStatus",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            AdminAuthenticated = true;

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Failed to validate admin key:\n{ex.Message}",
                "HPSkyStatus",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        finally
        {
            txtAdminKey.Enabled = true;
        }
    }


}