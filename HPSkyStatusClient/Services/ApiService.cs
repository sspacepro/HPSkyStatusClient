using System.Net.Http.Headers;
using HPSkyStatusClient.Configuration;
using Microsoft.Extensions.Options;

namespace HPSkyStatusClient.Services;

public class ApiService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ClientSettingsService _clientSettings;
    private readonly ApiSettings _apiSettings;

    public ApiService(
        IHttpClientFactory httpClientFactory,
        ClientSettingsService clientSettings,
        IOptions<ApiSettings> apiSettings)
    {
        _httpClientFactory = httpClientFactory;
        _clientSettings = clientSettings;
        _apiSettings = apiSettings.Value;
    }

    private HttpClient CreateClient()
    {
        var client = _httpClientFactory.CreateClient();

        client.BaseAddress = new Uri(_apiSettings.Url);

        if (!string.IsNullOrWhiteSpace(_clientSettings.Settings.ClientId))
        {
            client.DefaultRequestHeaders.Add(
                "Client-ID",
                _clientSettings.Settings.ClientId);
        }

        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

        return client;
    }

    public async Task<HttpResponseMessage?> GetAsync(string url)
    {
        try
        {
            using var client = CreateClient();
            return await client.GetAsync(url);
        }
        catch
        {
            return null;
        }
    }


    public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
    {
        using var client = CreateClient();
        return await client.PostAsync(url, content);
    }

    public async Task<HttpResponseMessage> DeleteAsync(string url)
    {
        using var client = CreateClient();
        return await client.DeleteAsync(url);
    }
}