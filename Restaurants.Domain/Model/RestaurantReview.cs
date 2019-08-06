using Restaurants.Infra.Core;

namespace Restaurants.Domain.Model
{
    public class RestaurantReview:BaseModifiableEntity<int>
    {
        public int Rating { get; set; }
        public string Body { get; set; }
        public string ReviewerName { get; set; }
        public int RestaurantID { get; set; }
    }
}
