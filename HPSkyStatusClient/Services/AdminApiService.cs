using HPSkyStatusClient.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
namespace HPSkyStatusClient.Services;

public class AdminApiService
{
    private readonly ApiService _api;

    private string? _adminKey;

    public bool IsAuthenticated =>
        !string.IsNullOrWhiteSpace(_adminKey);

    public AdminApiService(ApiService api)
    {
        _api = api;
    }

    public void SetKey(string key)
    {
        _adminKey = key;
    }

    private HttpRequestMessage CreateRequest(
        HttpMethod method,
        string url)
    {
        var request = new HttpRequestMessage(
            method,
            url);

        if (!string.IsNullOrWhiteSpace(_adminKey))
        {
            request.Headers.Add(
                "Admin-Key",
                _adminKey);
        }

        return request;
    }


    public async Task<HttpResponseMessage?> Get(
        string endpoint)
    {
        using var request =
            CreateRequest(
                HttpMethod.Get,
                endpoint);

        return await _api.SendAsync(request);
    }


    public async Task<HttpResponseMessage?> Post(
        string endpoint,
        HttpContent? content = null)
    {
        using var request =
            CreateRequest(
                HttpMethod.Post,
                endpoint);

        request.Content =
            content ?? new StringContent("");

        return await _api.SendAsync(request);
    }

    public async Task<string?> GetString(string endpoint)
    {
        var response = await Get(endpoint);

        if (response == null || !response.IsSuccessStatusCode)
            return null;

        return await response.Content.ReadAsStringAsync();
    }

    public async Task<List<AdminUser>> GetUsers()
    {
        var response = await Get("/api/admin/users");

        if (response == null || !response.IsSuccessStatusCode)
            return new();

        return JsonSerializer.Deserialize<List<AdminUser>>(
            await response.Content.ReadAsStringAsync(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }) ?? new();
    }
    public async Task<bool> BlockUser(string username)
    {
        var response =
            await Post($"/api/admin/users/{username}/block");

        return response != null &&
               response.IsSuccessStatusCode;
    }
    public async Task<bool> UnblockUser(string username)
    {
        var response =
            await Post($"/api/admin/users/{username}/unblock");

        return response != null &&
               response.IsSuccessStatusCode;
    }
    public async Task<bool> DeleteUser(string clientId)
    {
        using var request =
            CreateRequest(
                HttpMethod.Delete,
                $"/api/admin/users/{clientId}");

        var response =
            await _api.SendAsync(request);

        return response != null &&
               response.IsSuccessStatusCode;
    }
    public async Task<int?> PurgeInactiveUsers(int days)
    {
        var response =
            await Post($"/api/admin/users/purge-inactive/{days}");

        if (response == null || !response.IsSuccessStatusCode)
            return null;

        var json =
            await response.Content.ReadAsStringAsync();

        using var document =
            JsonDocument.Parse(json);

        return document.RootElement
            .GetProperty("removed")
            .GetInt32();
    }
    public async Task<bool> ShutdownServer()
    {
        var response =
            await Post("/api/admin/shutdown");

        return response != null &&
               response.IsSuccessStatusCode;
    }
    public async Task<AdminStatusResponse?> GetStatus()
    {
        var response = await Get("/api/admin/status");

        if (response == null || !response.IsSuccessStatusCode)
            return null;

        return await response.Content.ReadFromJsonAsync<AdminStatusResponse>();
    }
    public async Task<AdminStatusResponse?> PostBackup()
    {
        var response = await Post("/api/admin/backup");

        if (response == null || !response.IsSuccessStatusCode)
            return null;

        return await response.Content.ReadFromJsonAsync<AdminStatusResponse>();
    }
    public async Task<bool> SendNotification(
    string title,
    string message,
    List<string>? clientIds)
    {
        var request = new AdminNotificationRequest
        {
            Title = title,
            Message = message,
            ClientIds = clientIds
        };

        using var content =
            JsonContent.Create(request);

        var response =
            await Post(
                "/api/admin/notifications",
                content);

        return response != null &&
               response.IsSuccessStatusCode;
    }
}