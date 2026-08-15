using System.Runtime.InteropServices;

namespace HPSkyStatusClient.Services;

public static class StartMenuService
{
    public static void CreateShortcut()
    {
        string startMenu = Environment.GetFolderPath(
            Environment.SpecialFolder.StartMenu);

        string programsFolder = Path.Combine(
            startMenu,
            "Programs");

        Directory.CreateDirectory(programsFolder);

        string shortcutPath = Path.Combine(
            programsFolder,
            "HPSkyStatus.lnk");

        if (File.Exists(shortcutPath))
            return;

        string exePath = Application.ExecutablePath;

        Type? shellType = Type.GetTypeFromProgID("WScript.Shell");

        if (shellType == null)
            return;

        dynamic shell = Activator.CreateInstance(shellType)!;

        try
        {
            dynamic shortcut =
                shell.CreateShortcut(shortcutPath);

            shortcut.TargetPath = exePath;
            shortcut.WorkingDirectory =
                Path.GetDirectoryName(exePath);

            shortcut.Description =
                "HPSkyStatus";

            shortcut.IconLocation =
                $"{exePath},0";

            shortcut.Save();
        }
        finally
        {
            Marshal.ReleaseComObject(shell);
        }
    }
}