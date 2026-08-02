using System.Text;
using System.Text.Json;
using HPSkyStatusClient.Models;

namespace HPSkyStatusClient.Services;

public class AuctionWatchService
{
    private readonly ApiService _api;

    public AuctionWatchService(ApiService api)
    {
        _api = api;
    }

    public async Task<List<AuctionWatch>> GetWatches()
    {
        var response = await _api.GetAsync(
            "/api/v1/auction/watch");

        if (response == null || !response.IsSuccessStatusCode)
            return new List<AuctionWatch>();

        return JsonSerializer.Deserialize<List<AuctionWatch>>(
            await response.Content.ReadAsStringAsync(),
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            })
            ?? new List<AuctionWatch>();
    }


    public async Task<(bool Success, string Error)> AddWatch(
        AuctionWatch watch)
    {
        var json = JsonSerializer.Serialize(new
        {
            itemTag = watch.ItemTag,
            tier = watch.Tier,
            stars = watch.Stars,
            recombobulated = watch.Recombobulated,
            petXp = watch.PetXp,
            notifyBelow = watch.NotifyBelow
        });


        var response = await _api.PostAsync(
            "/api/v1/auction/watch",
            new StringContent(
                json,
                Encoding.UTF8,
                "application/json"));

        if (response.IsSuccessStatusCode)
            return (true, "");

        return (
            false,
            await response.Content.ReadAsStringAsync());
    }


    public async Task<(bool Success, string Error)> RemoveWatch(
        Guid watchId)
    {
        var response = await _api.DeleteAsync(
            $"/api/v1/auction/watch/{watchId}");

        if (response.IsSuccessStatusCode)
            return (true, "");

        return (
            false,
            await response.Content.ReadAsStringAsync());
    }
}