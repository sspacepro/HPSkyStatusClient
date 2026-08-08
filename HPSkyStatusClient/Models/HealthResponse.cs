using System.Text.Json.Serialization;

namespace HPSkyStatusClient.Models;

public class HealthResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; } = "";

    [JsonPropertyName("uptimeSeconds")]
    public int UptimeSeconds { get; set; }

    [JsonPropertyName("hypixelOnline")]
    public bool HypixelOnline { get; set; }

    [JsonPropertyName("skyBlockPlayers")]
    public int SkyBlockPlayers { get; set; }

    [JsonPropertyName("cachedAuctions")]
    public int CachedAuctions { get; set; }

    [JsonPropertyName("cachedItems")]
    public int CachedItems { get; set; }

    [JsonPropertyName("queuedNotifications")]
    public int QueuedNotifications { get; set; }
}