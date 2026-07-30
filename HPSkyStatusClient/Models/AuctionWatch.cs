namespace HPSkyStatusClient.Models;

public class AuctionWatch
{
    public Guid WatchId { get; set; }

    public string ItemTag { get; set; } = "";

    public string Tier { get; set; } = "";

    public int? Stars { get; set; }

    public bool? Recombobulated { get; set; }

    public int? PetXp { get; set; }

    public long NotifyBelow { get; set; }

    public long LastLowestBin { get; set; }

    public bool Available { get; set; }

    public string DisplayItemName { get; set; } = "";

    public string ItemLore { get; set; } = "";
}