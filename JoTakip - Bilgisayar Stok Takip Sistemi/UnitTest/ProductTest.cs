using System;
using System.Collections.Generic;
using System.Linq;
using Business;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void BuyProduct()
        {
            IProductService productService = IocUtil.Resolve<IProductService>();
            IWarehouseService warehouse = IocUtil.Resolve<IWarehouseService>();

            Product product = new Product() { Name = "buy product test" };

            productService.BuyProduct(product, 5);

            Assert.AreEqual(5, warehouse.GetProducts().Count(x => x.Name == product.Name));
        }

        [TestMethod]
        public void AssignProduct()
        {
            IPersonalService personalService = IocUtil.Resolve<IPersonalService>();
            IProductService productService = IocUtil.Resolve<IProductService>();
            IWarehouseService warehouse = IocUtil.Resolve<IWarehouseService>();

            Personal personal = new Personal() { Name = "Test", LastName = "Personal", StillEmployed = true };

            personalService.Add(personal);

            Product product = warehouse.GetProducts()[0];

            productService.AssignProduct(personal, product);

            product = warehouse.GetProducts()[0];

            Assert.AreEqual(personal.Id, product.AssignedById);
        }
    }
}
