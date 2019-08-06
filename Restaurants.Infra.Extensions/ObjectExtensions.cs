using System;

namespace Restaurants.Infra.Extensions
{
    public static class ObjectExtensions
    {
        public static TDest MapTo<TDest>(this object src)
        {
            return (TDest)AutoMapper.Mapper.Map(src, src.GetType(), typeof(TDest));
        }
    }
}
