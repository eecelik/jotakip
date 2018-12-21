using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Warehouse : IWarehouseManager
    {
        private List<Product> products { get; set; }

        public void AddProducts(List<Product> products)
        {
            this.products.AddRange(products);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
