using IOC;

IContainer container = new Container();
container.Register<ILogger, ConsoleLogger>();
container.Register<Email, Email>();

Email email = container.Resolve<Email>();
email.SendNotification();