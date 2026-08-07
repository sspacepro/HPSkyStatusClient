namespace HPSkyStatusClient.Models;

public class AdminUser
{
    public string Username { get; set; } = "";

    public bool Blocked { get; set; }

    public DateTime LastSeen { get; set; }

    public string ClientId { get; set; } = "";
}