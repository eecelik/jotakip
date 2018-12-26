using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        void AssignProduct(Personal personal, Product product);
        void BuyProduct(IWarehouseService warehouse, Product product, int count);
        void WasteProduct(Product product);
    }
}
