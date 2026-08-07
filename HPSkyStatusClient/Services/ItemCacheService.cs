using System.Text.Json;
using HPSkyStatusClient.Models;

namespace HPSkyStatusClient.Services;

public class ItemCacheService
{
    private readonly ApiService _api;

    public List<HypixelItem> Items { get; private set; } = new();

    public ItemCacheService(ApiService api)
    {
        _api = api;
    }


    public async Task Load()
    {
        var response =
            await _api.GetAsync("/api/v1/items");

        if (response == null)
            return;


        Items =
            JsonSerializer.Deserialize<List<HypixelItem>>(
                await response.Content.ReadAsStringAsync(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                })
            ?? new();
    }


    public List<HypixelItem> Search(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return new();


        return Items
            .Where(x =>
                StripColors(x.Name)
                .Contains(
                    text,
                    StringComparison.OrdinalIgnoreCase))
            .Take(10)
            .ToList();
    }


    public static string StripColors(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] == '§')
            {
                text =
                    text.Remove(i, 2);

                i--;
            }
        }

        return text;
    }
    public HypixelItem? GetById(string id)
    {
        return Items.FirstOrDefault(x =>
            string.Equals(x.Id, id, StringComparison.OrdinalIgnoreCase));
    }
    public string GetDisplayName(string id)
    {
        var item = GetById(id);

        return item?.DisplayName ?? id;
    }
    public string? GetTier(string itemId)
    {
        return GetById(itemId)?.Tier;
    }
}