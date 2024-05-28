﻿using Microsoft.Extensions.Logging;

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
        Console.WriteLine($"{message}");
        logger.LogInformation(message);
    }
}