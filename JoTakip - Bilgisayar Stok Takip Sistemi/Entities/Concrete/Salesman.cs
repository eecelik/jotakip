using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Salesman : User, IEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
