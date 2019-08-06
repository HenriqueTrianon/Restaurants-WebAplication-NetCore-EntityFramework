using System.Collections.Generic;
using Restaurants.Infra.Core;

namespace Restaurants.Domain.Model
{
    public class Restaurant:BaseModifiableEntity<int>
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public virtual ICollection<RestaurantReview> Reviews { get; set; }

    }
}
