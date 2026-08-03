namespace HPSkyStatusClient.Models;

public class ClientPreferences
{
    public string ServerUrl { get; set; } = "";

    public int NotificationHistoryMinutes { get; set; } = 60;

    public bool PlayerNotifications { get; set; } = true;

    public bool AuctionNotifications { get; set; } = true;

    public bool StartupNotificationHistory { get; set; } = true;

    public bool MinimizeToTray { get; set; } = true;
}