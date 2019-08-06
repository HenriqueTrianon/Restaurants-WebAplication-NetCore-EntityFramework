using SimpleInjector;

namespace Restaurants.Infra.IoC
{
    public class RestaurantInjector:DependencyInjector<RestaurantInjector>
    {
        protected override Container ConfigureServices(Container container)
        {
            return container;
        }

        protected override Container ConfigureRepositories(Container container)
        {
            return container;
        }

        protected override Container ConfigureValidators(Container container)
        {
            return container;
        }
    }
}
