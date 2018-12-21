using Business.Abstract;
using Business.Concrete;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;

namespace Business
{
    public static class IocUtil
    {
        private static IWindsorContainer _container;
        private static IWindsorContainer Container { get { if (_container == null) _container = BootstrapContainer(); return _container; } }

        private static IWindsorContainer BootstrapContainer()
        {
            return new WindsorContainer().Register(
                Component.For<IProductManager>().ImplementedBy<ProductManager>(),
                Component.For<IWarehouseManager>().ImplementedBy<Warehouse>()

                );
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
