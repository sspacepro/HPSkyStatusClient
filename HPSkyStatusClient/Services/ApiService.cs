using System.Net.Http.Headers;
using HPSkyStatusClient.Configuration;
using Microsoft.Extensions.Options;

namespace HPSkyStatusClient.Services;

public class ApiService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ClientSettingsService _clientSettings;


    public ApiService(
        IHttpClientFactory httpClientFactory,
        ClientSettingsService clientSettings)
    {
        _httpClientFactory = httpClientFactory;
        _clientSettings = clientSettings;
    }

    private HttpClient CreateClient()
    {
        var client = _httpClientFactory.CreateClient();

        client.BaseAddress = new Uri(
            _clientSettings.Settings.ServerUrl);

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
    public async Task<HttpResponseMessage?> SendAsync(
    HttpRequestMessage request)
    {
        try
        {
            using var client = CreateClient();

            if (request.RequestUri is not null &&
                !request.RequestUri.IsAbsoluteUri)
            {
                request.RequestUri = new Uri(
                    client.BaseAddress!,
                    request.RequestUri);
            }

            return await client.SendAsync(request);
        }
        catch
        {
            return null;
        }
    }
}