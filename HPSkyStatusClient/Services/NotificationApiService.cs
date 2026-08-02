using System.Text.Json;
using HPSkyStatusClient.Models;

namespace HPSkyStatusClient.Services;

public class NotificationApiService
{
    private readonly ApiService _api;

    public NotificationApiService(ApiService api)
    {
        _api = api;
    }

    public async Task<List<ClientNotification>> GetNotifications()
    {
        var response = await _api.GetAsync(
            "/api/v1/notifications");

        if (response == null || !response.IsSuccessStatusCode)
            return new List<ClientNotification>();

        var json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<List<ClientNotification>>(
            json,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            })
            ?? new List<ClientNotification>();
    }
}