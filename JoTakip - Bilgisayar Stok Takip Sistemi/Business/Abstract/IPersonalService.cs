using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonalService
    {
        void Add(Personal personal);
        void Update(Personal personal);
        void Delete(Personal personal);
        List<Personal> GetList();
    }
}
