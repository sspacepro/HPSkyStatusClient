
namespace HPSkyStatusClient.Services;

public static class MinecraftTextRenderer
{
    private static readonly Dictionary<char, Color> Colors = new()
    {
        ['0'] = Color.Black,
        ['1'] = Color.FromArgb(0, 0, 170),
        ['2'] = Color.FromArgb(0, 170, 0),
        ['3'] = Color.FromArgb(0, 170, 170),
        ['4'] = Color.FromArgb(170, 0, 0),
        ['5'] = Color.FromArgb(170, 0, 170),
        ['6'] = Color.FromArgb(255, 170, 0),
        ['7'] = Color.FromArgb(170, 170, 170),
        ['8'] = Color.FromArgb(85, 85, 85),
        ['9'] = Color.FromArgb(85, 85, 255),
        ['a'] = Color.FromArgb(85, 255, 85),
        ['b'] = Color.FromArgb(85, 255, 255),
        ['c'] = Color.FromArgb(255, 85, 85),
        ['d'] = Color.FromArgb(255, 85, 255),
        ['e'] = Color.FromArgb(255, 255, 85),
        ['f'] = Color.White
    };

    public static void Render(RichTextBox box, string text)
    {
        box.Clear();

        Color currentColor = Color.Black;
        FontStyle currentStyle = FontStyle.Regular;

        // Cache fonts by style to avoid creating a new Font per character
        var fontCache = new Dictionary<FontStyle, Font>();

        try
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '§' && i + 1 < text.Length)
                {
                    char code = char.ToLower(text[i + 1]);

                    if (Colors.TryGetValue(code, out var color))
                    {
                        currentColor = color;
                    }
                    else
                    {
                        switch (code)
                        {
                            case 'l':
                                currentStyle |= FontStyle.Bold;
                                break;

                            case 'o':
                                currentStyle |= FontStyle.Italic;
                                break;

                            case 'n':
                                currentStyle |= FontStyle.Underline;
                                break;

                            case 'm':
                                currentStyle |= FontStyle.Strikeout;
                                break;

                            case 'r':
                                currentColor = Color.Black;
                                currentStyle = FontStyle.Regular;
                                break;
                        }
                    }

                    i++;
                    continue;
                }

                if (!fontCache.TryGetValue(currentStyle, out var font))
                {
                    font = new Font(box.Font, currentStyle);
                    fontCache[currentStyle] = font;
                }

                box.SelectionColor = currentColor;
                box.SelectionFont = font;
                box.AppendText(text[i].ToString());
            }
        }
        finally
        {
            foreach (var font in fontCache.Values)
                font.Dispose();
        }

        box.SelectionStart = 0;
        box.SelectionLength = 0;
    }
}