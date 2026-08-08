using System.Drawing.Text;

namespace HPSkyStatusClient.Services;

public static class CustomFontService
{
    private static readonly PrivateFontCollection Fonts = new();

    public static Font LoadFont(
        string fileName,
        float size,
        FontStyle style = FontStyle.Regular)
    {
        string path = Path.Combine(
            AppContext.BaseDirectory,
            "Fonts",
            fileName);

        Fonts.AddFontFile(path);

        return new Font(
            Fonts.Families[^1],
            size,
            style);
    }
}