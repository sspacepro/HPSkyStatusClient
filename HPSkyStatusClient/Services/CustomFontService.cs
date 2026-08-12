using System.Drawing.Text;

namespace HPSkyStatusClient.Services;

public static class CustomFontService
{
    private static readonly PrivateFontCollection Fonts = new();
    private static readonly Dictionary<string, FontFamily> LoadedFonts = new(StringComparer.OrdinalIgnoreCase);

    public static Font LoadFont(
        string fileName,
        float size,
        FontStyle style = FontStyle.Regular)
    {
        string path = Path.Combine(
            AppDataService.DirectoryPath,
            "Fonts",
            fileName);

        if (!File.Exists(path))
            throw new FileNotFoundException($"Font file not found: {path}");

        if (!LoadedFonts.TryGetValue(path, out var family))
        {
            Fonts.AddFontFile(path);
            family = Fonts.Families[^1];
            LoadedFonts[path] = family;
        }

        return new Font(family, size, style);
    }
}