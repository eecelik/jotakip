﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWarehouseService
    {
        List<Product> GetProducts();
        void AddProducts(List<Product> products);
        void DeleteProduct(Product product);
    }
}
