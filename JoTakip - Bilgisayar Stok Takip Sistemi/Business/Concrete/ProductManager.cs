using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            productDal.Delete(product);
            personalDal.Get(x => x.No == personal.No).HasProducts.Add(product);
        }

        public void BuyProduct(IWarehouseService warehouse, Product product, int count)
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < count; i++) products.Add(product);

            warehouse.AddProducts(products);
        }

        public void WasteProduct(Product product)
        {
            foreach (Personal personal in personalDal.GetList())
            {
                Product wastingProduct = personal.HasProducts.SingleOrDefault(x => x.No == product.No);

                if (wastingProduct == null) continue;

                personal.HasProducts.Remove(wastingProduct);
            }
        }
    }
}
