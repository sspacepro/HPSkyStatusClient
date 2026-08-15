using HPSkyStatusClient.Models;

namespace HPSkyStatusClient;

public partial class MainForm
{
    private async Task CheckNotifications(bool startup = false)
    {
        var notifications = await _notificationApiService.GetNotifications();

        foreach (var notification in notifications)
        {
            if (!ShouldShowNotification(notification))
                continue;

            if (startup)
            {
                if (!_preferences.Preferences.StartupNotificationHistory)
                    continue;

                var age = DateTime.UtcNow - notification.Created;

                if (age.TotalMinutes > _preferences.Preferences.NotificationHistoryMinutes)
                    continue;
            }

            var message = notification.Message;

            if (startup)
            {
                message += $" ({_notificationTime.Format(notification.Created)})";
            }

            _notifications.Show(notification.Title, message, notification.Type);
        }
    }

    private bool ShouldShowNotification(ClientNotification notification)
    {
        if (notification.Type.Equals("admin", StringComparison.OrdinalIgnoreCase))
            return true;

        if (notification.Type.Equals("auction", StringComparison.OrdinalIgnoreCase) &&
            !_preferences.Preferences.AuctionNotifications)
            return false;

        return true;
    }
}