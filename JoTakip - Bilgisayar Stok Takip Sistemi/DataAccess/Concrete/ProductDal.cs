using System.Collections.Generic;
using System.Data.Entity;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class ProductDal : EntityRepositoryBase<Product, SqlContext>, IProductDal
    {
        public void AddRange(List<Product> entities)
        {
            using (var context = new SqlContext())
            {
                var addedEntity = context.Entry(entities);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
