using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    interface ISalesmanService
    {
        void Add(Salesman salesman);
        void Update(Salesman salesman);
        void Delete(Salesman salesman);
        List<Salesman> GetList();
    }
}
