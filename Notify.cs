namespace NotificationService;

public class Notify() : INotify
{
    /// <summary>
    /// Notifies the completion of a Hangfire process
    /// </summary>
    /// <param name="message"></param>
    public void ProcessingCompletion(string message)
    {
        Console.WriteLine($"=========");
        Console.WriteLine(message);
    }
}