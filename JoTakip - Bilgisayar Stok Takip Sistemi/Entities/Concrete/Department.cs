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
    public class Department : IEntity
    {
        [Key, ForeignKey("Manager")]
        public int No { get; set; }
        public string Name { get; set; }
        public Personal Manager { get; set; }
    }
}
