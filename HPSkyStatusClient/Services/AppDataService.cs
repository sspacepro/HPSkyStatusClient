namespace HPSkyStatusClient.Services;

public static class AppDataService
{
    public static string DirectoryPath =>
        Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData),
            "HPSkyStatus");

    public static string GetFilePath(string fileName)
    {
        Directory.CreateDirectory(DirectoryPath);

        return Path.Combine(DirectoryPath, fileName);
    }
}