using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01.Models
{
    internal class EmployeeDepartmentView
    {
        public int EmpID { get; set; }
        public string? EmployeeName { get; set; }

        public int DepartmentId { get; set; }
        public string? DeptName { get; set; }
    }
}
