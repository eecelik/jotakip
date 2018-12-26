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
    public class PersonalManager : IPersonalService
    {
        IPersonalDal personalDal;

        public PersonalManager(IPersonalDal personalDal)
        {
            this.personalDal = personalDal;
        }

        public void Add(Personal personal)
        {
            personalDal.Add(personal);
        }

        public void Delete(Personal personal)
        {
            personalDal.Delete(personal);
        }

        public List<Personal> GetList()
        {
            return personalDal.GetList();
        }

        public void Update(Personal personal)
        {
            personalDal.Update(personal);
        }
    }
}
