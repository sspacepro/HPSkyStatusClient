using System.Text.Json;

using HPSkyStatusClient.Models;


namespace HPSkyStatusClient.Services;


public class NotificationHistoryService
{
    private readonly string _path = Path.Combine(
        AppContext.BaseDirectory,
        "notification-history.json");

    private readonly HashSet<string> _shown = new();

    public NotificationHistoryService()
    {
        Load();
    }

    public bool HasShown(ClientNotification notification)
    {
        return _shown.Contains(GetKey(notification));
    }

    public void MarkShown(ClientNotification notification)
    {
        if (_shown.Add(GetKey(notification)))
            Save();
    }

    private static string GetKey(ClientNotification notification)
    {
        return $"{notification.Created:O}|{notification.Title}|{notification.Message}";
    }

    private void Load()
    {
        if (!File.Exists(_path))
            return;

        var json = File.ReadAllText(_path);
        var keys = JsonSerializer.Deserialize<List<string>>(json);

        if (keys == null)
            return;

        foreach (var key in keys)
            _shown.Add(key);
    }

    private void Save()
    {
        var json = JsonSerializer.Serialize(
    _shown.ToList(),
    new JsonSerializerOptions
    {
        WriteIndented = true
    });

        File.WriteAllText(_path, json);
    }
}
