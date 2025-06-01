namespace Logs;

public static partial class Logs
{
    [LoggerMessage(
        EventId = 4,
        Level = LogLevel.Critical,
        Message = "This won't show up for some reason {EventId}."
    )]
    public static partial void LogNotEmitted(this ILogger logger, string eventId);

    [LoggerMessage(
        EventId = 5,
        Level = LogLevel.Critical,
        Message = "This will show up {Hi}."
    )]
    public static partial void LogEmitted(this ILogger logger, string hi);
}
