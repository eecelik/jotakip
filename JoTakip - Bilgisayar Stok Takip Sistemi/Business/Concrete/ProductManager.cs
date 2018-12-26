using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal productDal;
        private IPersonalDal personalDal;

        public ProductManager(IProductDal productDal, IPersonalDal personalDal)
        {
            this.productDal = productDal;
            this.personalDal = personalDal;
        }

        public void AssignProduct(Personal personal, Product product)
        {
            product.AssignedById = personal.Id;
            productDal.Update(product);
        }

        public void BuyProduct(Product product, int count)
        {
            IWarehouseService warehouse = new WarehouseManager(productDal);

            List<Product> products = new List<Product>();

            for (int i = 0; i < count; i++) products.Add(product);

            warehouse.AddProducts(products);
        }

        public void WasteProduct(Product product)
        {
            productDal.Delete(product);
        }
    }
}
