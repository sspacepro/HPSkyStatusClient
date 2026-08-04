using System.Net.Http.Headers;

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
}