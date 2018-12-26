using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Department : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }
    }
}
