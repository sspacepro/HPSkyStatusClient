
using System.Drawing;


namespace HPSkyStatusClient.Services;

public static class TrayColorService
{
    public static Color GetColor(
        string? rarity,
        bool recombobulated = false)
    {
        // Let the normal rarity service handle
        // recombobulation and rarity progression.
        if (recombobulated)
        {
            rarity = rarity?.ToUpperInvariant() switch
            {
                "COMMON" => "UNCOMMON",
                "UNCOMMON" => "RARE",
                "RARE" => "EPIC",
                "EPIC" => "LEGENDARY",
                "LEGENDARY" => "MYTHIC",
                "MYTHIC" => "DIVINE",
                "DIVINE" => "SPECIAL",
                _ => rarity
            };
        }

        return rarity?.ToUpperInvariant() switch
        {
            // Darker versions that remain readable
            // in both light and dark Windows menus.
            "COMMON" => Color.Gray,
            "UNCOMMON" => Color.Green,
            "RARE" => Color.RoyalBlue,
            "EPIC" => Color.MediumPurple,
            "LEGENDARY" => Color.DarkGoldenrod,
            "MYTHIC" => Color.DeepPink,
            "DIVINE" => Color.OrangeRed,
            "SPECIAL" => Color.Red,
            "VERY SPECIAL" => Color.Red,

            _ => Color.Black
        };
    }
}

