using System.Text;
using System.Text.Json;
using HPSkyStatusClient.Models;

namespace HPSkyStatusClient.Services;

public class AuthenticationService
{
    private readonly ApiService _api;
    private readonly ClientSettingsService _settings;

    public AuthenticationService(
        ApiService api,
        ClientSettingsService settings)
    {
        _api = api;
        _settings = settings;
    }

    public bool IsRegistered()
    {
        return !string.IsNullOrWhiteSpace(
            _settings.Settings.ClientId);
    }

    public async Task<bool> Register(string username)
    {
        var json = JsonSerializer.Serialize(new
        {
            username
        });

        var content = new StringContent(
            json,
            Encoding.UTF8,
            "application/json");

        var response = await _api.PostAsync(
            "/api/v1/register",
            content);

        if (!response.IsSuccessStatusCode)
            return false;

        var responseText = await response.Content.ReadAsStringAsync();


        var result = JsonSerializer.Deserialize<RegisterResponse>(
    responseText,
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });

       
        if (result == null)
            return false;

        _settings.Settings.ClientId = result.ClientId;
        _settings.Settings.Username = result.Username;
        _settings.Save();

        return true;
    }
}