namespace HPSkyStatusClient.Services;

using System.Windows.Forms;

public class NotificationService
{
    private readonly NotifyIcon _trayIcon;

    public NotificationService(NotifyIcon trayIcon)
    {
        _trayIcon = trayIcon;
    }

    public void Show(
        string title,
        string message,
        string? type)
    {
        if (string.Equals(
                type,
                "admin",
                StringComparison.OrdinalIgnoreCase))
        {
            MessageBox.Show(
                message,
                title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        _trayIcon.ShowBalloonTip(
            5000,
            title,
            message,
            ToolTipIcon.Info);
    }
}
