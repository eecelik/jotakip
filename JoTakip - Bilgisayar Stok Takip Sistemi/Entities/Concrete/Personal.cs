using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Personal : IEntity
    {
        [Key]
        public int No { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Product> HasProducts { get; set; }
        public bool StillEmployed { get; set; }
        public Department Department { get; set; }
    }
}
