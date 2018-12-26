using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        void AddRange(List<Product> entities);
    }
}
