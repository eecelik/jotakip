using System;
using Business;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class DataAccessTest
    {
        [TestMethod]
        public void AddProduct()
        {
            Product product = new Product() { Name = "unit test product" };

            IProductDal productManager = IocUtil.Resolve<IProductDal>();

            productManager.Add(product);

            productManager.GetList();

            bool isAdded = productManager.GetList().Exists(x => x.Name == product.Name);

            Assert.AreEqual(true, isAdded);
        }
    }
}
