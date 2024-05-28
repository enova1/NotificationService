using Microsoft.Extensions.Logging;

#pragma warning disable CA2254

namespace NotificationService;

public class Notify(ILogger<Notify> logger) : INotify
{
    /// <summary>
    /// Notifies the completion of a Hangfire process
    /// </summary>
    /// <param name="message"></param>
    public void ProcessingCompletion(string message)
    {
        Console.WriteLine($"=========");
        logger.LogInformation(message);
    }
}