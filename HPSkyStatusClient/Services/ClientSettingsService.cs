using System.Text.Json;
using HPSkyStatusClient.Configuration;

namespace HPSkyStatusClient.Services;

public class ClientSettingsService
{
    private const string FileName = "clientsettings.json";
    private readonly string _path = Path.Combine(AppContext.BaseDirectory, FileName);

    public ClientSettings Settings { get; }
    public const string DefaultServerUrl =
    "http://localhost:5122";
    public ClientSettingsService()
    {
        if (File.Exists(_path))
        {
            Settings = JsonSerializer.Deserialize<ClientSettings>(
                File.ReadAllText(_path))
                ?? new ClientSettings();
        }
        else
        {
            Settings = new ClientSettings
            {
                ServerUrl = DefaultServerUrl
            };

            Save();
        }
        if (string.IsNullOrWhiteSpace(Settings.ServerUrl))
        {
            Settings.ServerUrl = DefaultServerUrl;
            Save();
        }
    }

    public void Save()
    {
        var json = JsonSerializer.Serialize(Settings, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(_path, json);
    }
}