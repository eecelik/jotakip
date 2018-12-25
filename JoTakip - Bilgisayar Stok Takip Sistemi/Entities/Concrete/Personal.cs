using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Personal : IEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Product> HasProducts { get; set; }
        public bool StillEmployed { get; set; }
        public Department Department { get; set; }
    }
}
