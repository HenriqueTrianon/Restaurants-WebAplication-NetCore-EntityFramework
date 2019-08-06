using System;

namespace Restaurants.Infra.Core
{
    public class BaseModifiableEntity<T>:IModifiableEntity<T>
    {
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
