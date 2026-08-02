namespace HPSkyStatusClient.Services;

public class NotificationTimeService
{
    public string Format(DateTime created)
    {
        var age = DateTime.UtcNow - created;

        if (age.TotalMinutes < 1)
            return "Just now";

        if (age.TotalHours < 1)
            return $"{(int)age.TotalMinutes} minutes ago";

        return $"{(int)age.TotalHours} hours ago";
    }
}