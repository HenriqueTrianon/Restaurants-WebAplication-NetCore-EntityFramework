using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurants.Infra.Core
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
