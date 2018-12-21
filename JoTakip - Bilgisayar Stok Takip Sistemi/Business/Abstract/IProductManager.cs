using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductManager
    {
        void AssignProduct(Personal personal, Product product);
        void BuyProduct(IWarehouseManager warehouse, Product product, int count);
        void WasteProduct(Product product);
    }
}
