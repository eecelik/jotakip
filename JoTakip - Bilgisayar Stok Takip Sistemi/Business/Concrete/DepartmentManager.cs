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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            this.departmentDal = departmentDal;
        }

        public void Add(Department department)
        {
            departmentDal.Add(department);
        }

        public void Delete(Department department)
        {
            departmentDal.Delete(department);
        }

        public List<Department> GetList()
        {
            return departmentDal.GetList();
        }

        public void Update(Department department)
        {
            departmentDal.Update(department);
        }
    }
}
