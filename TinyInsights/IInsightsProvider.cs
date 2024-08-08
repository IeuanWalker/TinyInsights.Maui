namespace TinyInsights;

public interface IInsightsProvider
{
    bool IsTrackErrorsEnabled { get; set; }
    public bool IsTrackCrashesEnabled { get; set; }
    bool IsTrackPageViewsEnabled { get; set; }
    bool IsTrackEventsEnabled { get; set; }
    bool IsTrackDependencyEnabled { get; set; }

    Task TrackErrorAsync(Exception ex, Dictionary<string, string>? properties = null);

    Task TrackPageViewAsync(string viewName, Dictionary<string, string>? properties = null);

    Task TrackEventAsync(string eventName, Dictionary<string, string>? properties = null);

    Task TrackDependencyAsync(string dependencyType, string dependencyName, string data, DateTimeOffset startTime, TimeSpan duration, bool success, int resultCode = 0, Exception? exception = null);
    void OverrideAnonymousUserId(string userId);
    void GenerateNewAnonymousUserId();
}