using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class ProductDal : EntityRepositoryBase<Product, SqlContext>, IProductDal
    {
    }
}
