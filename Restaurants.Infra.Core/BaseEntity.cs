using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Infra.Core
{
    public abstract class BaseEntity<T> : IEntity<T>
    {
        public T Id { get; set; }
    }
}
