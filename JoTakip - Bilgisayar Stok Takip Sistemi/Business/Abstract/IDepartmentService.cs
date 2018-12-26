﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        void Add(Department department);
        void Update(Department department);
        void Delete(Department department);
        List<Department> GetList();
    }
}
