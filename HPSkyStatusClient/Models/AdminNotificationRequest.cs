namespace HPSkyStatusClient.Models;

public class AdminNotificationRequest
{
    public string Title { get; set; } = "";
    public string Message { get; set; } = "";
    public List<string>? ClientIds { get; set; }
}