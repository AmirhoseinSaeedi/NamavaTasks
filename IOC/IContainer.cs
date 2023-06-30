namespace IOC
{
    public interface IContainer
    {
        void Register<TService, TImplementation>() where TImplementation : TService;
        TService Resolve<TService>();
    }
}
