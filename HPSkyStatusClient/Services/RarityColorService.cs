
using System.Drawing;

namespace HPSkyStatusClient.Services;

public static class RarityColorService
{
    public static Color GetColor(
        string? rarity,
        bool recombobulated = false)
    {
        if (recombobulated)
        {
            rarity = rarity?.ToUpper() switch
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

        return rarity?.ToUpper() switch
        {
            "COMMON" => Color.Black,
            "UNCOMMON" => Color.LimeGreen,
            "RARE" => Color.DeepSkyBlue,
            "EPIC" => Color.MediumPurple,
            "LEGENDARY" => Color.Gold,
            "MYTHIC" => Color.HotPink,
            "DIVINE" => Color.OrangeRed,
            "SPECIAL" => Color.Red,
            "VERY SPECIAL" => Color.Red,

            _ => Color.Black
        };
    }
}