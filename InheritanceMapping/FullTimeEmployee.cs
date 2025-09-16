using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMapping
{
    internal class FullTimeEmployee:Employee
    {
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
    }
}
