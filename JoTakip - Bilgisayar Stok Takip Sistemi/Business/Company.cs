using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class Company
    {
        public static User Admin { get; set; }
        public static IWarehouseManager Warehouse { get; set; }
        public static List<Personal> Personals { get; set; }
        public static List<Salesman> Salesmen { get; set; }
    }
}
