using System.Text.Json.Serialization;

namespace HPSkyStatusClient.Models;

public class AdminStatusResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; } = "";

    [JsonPropertyName("uptimeSeconds")]
    public int UptimeSeconds { get; set; }

    [JsonPropertyName("users")]
    public int Users { get; set; }

    [JsonPropertyName("skyBlockPlayers")]
    public int SkyBlockPlayers { get; set; }

    [JsonPropertyName("hypixelOnline")]
    public bool HypixelOnline { get; set; }

    [JsonPropertyName("cachedAuctions")]
    public int CachedAuctions { get; set; }

    [JsonPropertyName("cachedItems")]
    public int CachedItems { get; set; }

    [JsonPropertyName("queuedNotifications")]
    public int QueuedNotifications { get; set; }

    [JsonPropertyName("time")]
    public string Time { get; set; } = "";
}