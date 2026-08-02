using System.Text.Json;
using HPSkyStatusClient.Models;

namespace HPSkyStatusClient.Services;

public class StatusService
{
    private readonly ApiService _api;

    public StatusService(ApiService api)
    {
        _api = api;
    }

    public async Task<StatusResponse?> GetStatus()
    {
        try
        {
            var response = await _api.GetAsync("/api/v1/status");

            if (response == null || !response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<StatusResponse>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true

                });
        }
        
        catch
        {
            return null;
        }
    }
}