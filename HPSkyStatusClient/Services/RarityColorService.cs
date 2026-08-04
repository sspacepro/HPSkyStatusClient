using System.Drawing;

namespace HPSkyStatusClient.Services;

public static class RarityColorService
{
    public static Color GetColor(string? rarity)
    {
        return rarity?.ToUpper() switch
        {
            "COMMON" => Color.Black,
            "UNCOMMON" => Color.LimeGreen,
            "RARE" => Color.DeepSkyBlue,
            "EPIC" => Color.MediumPurple,
            "LEGENDARY" => Color.Gold,
            "MYTHIC" => Color.HotPink,

            _ => Color.Black
        };
    }
}