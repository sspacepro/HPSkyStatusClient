using System.Text.Json;
using HPSkyStatusClient.Models;

namespace HPSkyStatusClient.Services;

public class ClientSettingsApiService
{
    private readonly ApiService _api;

    public ClientSettingsResponse? Settings { get; private set; }

    public ClientSettingsApiService(ApiService api)
    {
        _api = api;
    }

    public async Task<bool> Refresh()
    {
        var response = await _api.GetAsync("/api/v1/client/settings");

        if (!response.IsSuccessStatusCode)
            return false;

        Settings = JsonSerializer.Deserialize<ClientSettingsResponse>(
            await response.Content.ReadAsStringAsync(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

        return Settings != null;
    }
}