using System.Text.Json;
using HPSkyStatusClient.Models;

namespace HPSkyStatusClient.Services;

public class ClientPreferencesService
{
    private const string FileName = "preferences.json";
    private readonly string _path = AppDataService.GetFilePath(FileName);

    public ClientPreferences Preferences { get; private set; } = new();

    public void Load()
    {
        if (!File.Exists(_path))
        {
            Save();
            return;
        }

        var json = File.ReadAllText(_path);

        Preferences =
            JsonSerializer.Deserialize<ClientPreferences>(json)
            ?? new ClientPreferences();
    }

    public void Save()
    {
        var json = JsonSerializer.Serialize(
            Preferences,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText(_path, json);
    }
}