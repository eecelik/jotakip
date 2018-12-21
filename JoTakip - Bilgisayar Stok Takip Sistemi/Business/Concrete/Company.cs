using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Company
    {
        public User Admin { get; set; }
        public Warehouse Warehouse { get; set; }

    }
}
