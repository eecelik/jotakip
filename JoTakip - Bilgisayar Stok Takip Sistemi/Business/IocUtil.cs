using Business.Abstract;
using Business.Concrete;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Core.Entities;
using Entities.Concrete;
using System.Security.Permissions;

namespace Business
{
    public static class IocUtil
    {
        private static IWindsorContainer _container;
        private static IWindsorContainer Container { get { if (_container == null) _container = BootstrapContainer(); return _container; } }

        private static IWindsorContainer BootstrapContainer()
        {
            return new WindsorContainer().Register(
                Component.For<IProductDal>().ImplementedBy<ProductDal>(),
                Component.For<IPersonalDal>().ImplementedBy<PersonalDal>()
                );
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
