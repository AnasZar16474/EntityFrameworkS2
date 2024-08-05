using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkS2.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public decimal Salary { get; set; }
}
}
