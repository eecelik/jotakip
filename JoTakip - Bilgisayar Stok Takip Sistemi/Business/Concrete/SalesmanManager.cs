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
    public class SalesmanManager : ISalesmanService
    {
        private ISalesmanDal salesmanDal;

        public SalesmanManager(ISalesmanDal salesmanDal)
        {
            this.salesmanDal = salesmanDal;
        }

        public void Add(Salesman salesman)
        {
            salesmanDal.Add(salesman);
        }

        public void Delete(Salesman salesman)
        {
            salesmanDal.Delete(salesman);
        }

        public List<Salesman> GetList()
        {
            return salesmanDal.GetList();
        }

        public void Update(Salesman salesman)
        {
            salesmanDal.Update(salesman);
        }
    }
}
