using System.Drawing.Text;
using System.Reflection;

namespace HPSkyStatusClient.Services;

public static class CustomFontService
{
    private static readonly PrivateFontCollection Fonts = new();

    private static readonly Dictionary<string, FontFamily> LoadedFonts =
        new(StringComparer.OrdinalIgnoreCase);

    public static Font LoadFont(
        string fileName,
        float size,
        FontStyle style = FontStyle.Regular)
    {
        if (!LoadedFonts.TryGetValue(fileName, out var family))
        {
            var assembly = Assembly.GetExecutingAssembly();

            string resourceName =
                $"{assembly.GetName().Name}.Fonts.{fileName}";

            using Stream? stream =
                assembly.GetManifestResourceStream(resourceName);

            if (stream == null)
            {
                throw new FileNotFoundException(
                    $"Embedded font resource not found: {resourceName}");
            }

            using var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);

            byte[] fontData = memoryStream.ToArray();

            unsafe
            {
                fixed (byte* ptr = fontData)
                {
                    Fonts.AddMemoryFont((IntPtr)ptr, fontData.Length);
                }
            }

            family = Fonts.Families[^1];
            LoadedFonts[fileName] = family;
        }

        return new Font(family, size, style);
    }
}