namespace HPSkyStatusClient.Configuration;

public class ClientSettings
{
    public string? ClientId { get; set; }

    public string ServerUrl { get; set; } = "";
    public string Username { get; set; } = "";

    public int NotificationHistoryMinutes { get; set; } = 60;
}