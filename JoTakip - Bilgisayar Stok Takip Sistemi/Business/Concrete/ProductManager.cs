using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductManager
    {
        public void AssignProduct(Personal personal, Product product)
        {
            throw new NotImplementedException();
        }

        public void BuyProduct(IWarehouseManager warehouse, Product product, int count)
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                products.Add(product);
            }

            warehouse.AddProducts(products);
        }

        public void WasteProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
