using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Domain.Model
{
    public class RestaurantReview
    {
        public int Rating { get; set; }
        public string Body { get; set; }
        public string ReviewerName { get; set; }
        public int RestaurantID { get; set; }

    }
}
