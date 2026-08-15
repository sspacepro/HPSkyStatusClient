using Microsoft.Win32;

namespace HPSkyStatusClient.Services;

public static class StartupService
{
    private const string AppName = "HPSkyStatus";

    public static void Enable()
    {
        using var key = Registry.CurrentUser.OpenSubKey(
            @"Software\Microsoft\Windows\CurrentVersion\Run",
            writable: true);

        if (key == null)
            return;

        string exePath = Application.ExecutablePath;
        string startupCommand = $"\"{exePath}\" --startup";

        string? currentPath = key.GetValue(AppName) as string;

        if (currentPath == startupCommand)
            return;

        key.SetValue(AppName, startupCommand);
    }
}