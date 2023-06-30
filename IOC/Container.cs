using System.Reflection;

namespace IOC
{
    public class Container : IContainer
    {
        private readonly Dictionary<Type, Type> _typeMapper = new Dictionary<Type, Type>();

        public void Register<TService, TImplementation>() where TImplementation : TService
        {
            _typeMapper[typeof(TService)] = typeof(TImplementation);
        }

        public TService Resolve<TService>()
        {
            return (TService)Resolve(typeof(TService));
        }

        private object Resolve(Type type)
        {
            Type implementationType = _typeMapper[type];
            ConstructorInfo constructor = implementationType.GetConstructors()[0];
            ParameterInfo[] parameters = constructor.GetParameters();
            object[] resolvedParameters = new object[parameters.Length];
            for (int i = 0; i < parameters.Length; i++)
            {
                Type parameterType = parameters[i].ParameterType;
                resolvedParameters[i] = Resolve(parameterType);
            }
            return constructor.Invoke(resolvedParameters);
        }
    }
}
