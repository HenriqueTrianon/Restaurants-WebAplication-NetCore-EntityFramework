using SimpleInjector;

namespace Restaurants.Infra.IoC
{
    public abstract  class DependencyInjector<T> where T: new()
    {
        public  Container Initialize()
        {
            return ConfigureValidators(ConfigureRepositories(ConfigureServices(new Container())));
        }

        public Container Initialize(Container container)
        {
            return ConfigureValidators(ConfigureRepositories(ConfigureServices(container)));
        }
        protected abstract Container ConfigureServices(Container container);
        protected abstract Container ConfigureRepositories(Container container);
        protected abstract Container ConfigureValidators(Container container);
        
    }
}
