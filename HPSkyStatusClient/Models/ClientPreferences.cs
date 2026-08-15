namespace HPSkyStatusClient.Models;

public class ClientPreferences
{
    public int NotificationHistoryMinutes { get; set; } = 60;

    public bool AuctionNotifications { get; set; } = true;

    public bool StartupNotificationHistory { get; set; } = true;

    public bool MinimizeToTray { get; set; } = true;

    public bool TrayIconPromptShown { get; set; }
}
