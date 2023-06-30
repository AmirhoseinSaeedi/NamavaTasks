namespace IOC
{
    public class Email
    {
        private readonly ILogger _logger;

        public Email(ILogger logger)
        {
            _logger = logger;
        }

        public void SendNotification()
        {
            _logger.Log("Notification");
        }
    }
}
