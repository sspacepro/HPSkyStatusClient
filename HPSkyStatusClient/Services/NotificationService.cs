namespace HPSkyStatusClient.Services;

public class NotificationService
{
    private readonly NotifyIcon _trayIcon;

    public NotificationService(NotifyIcon trayIcon)
    {
        _trayIcon = trayIcon;
    }

    public void Show(
        string title,
        string message)
    {
        _trayIcon.ShowBalloonTip(
            5000,
            title,
            message,
            ToolTipIcon.Info);
    }
}