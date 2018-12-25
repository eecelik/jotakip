using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class SqlContext:DbContext
    {
        public SqlContext() : base() {}

        public DbSet<Department> Departments { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Salesman> Salesmen { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
