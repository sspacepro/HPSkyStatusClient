using System.Text.Json;
using HPSkyStatusClient.Models;
using System.Net;

namespace HPSkyStatusClient.Services;

public class PlayerWatchService
{
    private readonly ApiService _api;

    public PlayerWatchService(ApiService api)
    {
        _api = api;
    }

    public async Task<List<PlayerStatus>> GetStatuses()
    {
        try
        {
            var response = await _api.GetAsync("/api/v1/watch/status");

            if (!response.IsSuccessStatusCode)
                return [];

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<PlayerStatus>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ?? [];
        }
        catch
        {
            return [];
        }
    }

    public async Task<(bool Success, string Error)> AddPlayer(string username)
    {
        var response = await _api.PostAsync(
            $"/api/v1/watch/{username}",
            new StringContent(""));

        if (response.IsSuccessStatusCode)
            return (true, "");

        return (
            false,
            await response.Content.ReadAsStringAsync());
    }

    public async Task<(bool Success, string Error)> RemovePlayer(string username)
    {
        var response = await _api.DeleteAsync(
            $"/api/v1/watch/{username}");

        if (response.IsSuccessStatusCode)
            return (true, "");

        return (
            false,
            await response.Content.ReadAsStringAsync());
    }
}