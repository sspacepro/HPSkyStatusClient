using System.Drawing;
using System.Windows.Forms;

namespace HPSkyStatusClient.Services;

public class SkyBlockMenuRenderer : ToolStripProfessionalRenderer
{
    protected override void OnRenderItemText(
        ToolStripItemTextRenderEventArgs e)
    {
        if (e.Item.Tag is Color color)
        {
            e.TextColor = color;
        }

        base.OnRenderItemText(e);
    }
}