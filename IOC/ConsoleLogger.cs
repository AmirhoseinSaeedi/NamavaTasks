namespace IOC
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Console Logging: {message}");
        }
    }
}
