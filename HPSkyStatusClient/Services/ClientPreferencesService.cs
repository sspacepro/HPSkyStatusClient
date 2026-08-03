using System.Text.Json;
using HPSkyStatusClient.Models;

namespace HPSkyStatusClient.Services;

public class ClientPreferencesService
{
    private const string FileName = "preferences.json";

    public ClientPreferences Preferences { get; private set; } = new();

    public void Load()
    {
        if (!File.Exists(FileName))
        {
            Save();
            return;
        }

        var json = File.ReadAllText(FileName);

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

        File.WriteAllText(FileName, json);
    }
}