using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Personal : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool StillEmployed { get; set; }
        public int DepartmentId { get; set; }
    }
}
