using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("DynamicProxyAssembly2")]

namespace EntitySession01.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }

        //Foreign Key
        //[ForeignKey("ManagerDept")]
        //public int ManagerDeptId { get; set; }
        ////Nevigation Property
        //public Department ManagerDept { get; set; }=null!;
        //Nevigation Property
        [InverseProperty(nameof(Department.Manager))]

        public virtual Department? ManagerDept { get; set; } = null!;

        public virtual Adress EmpAdress { get; set;  }= null!;


        //FK
        [ForeignKey("EmployeeDepartment")]
        public int? EmpDeptId { get; set; }
        //One to Many RS [Work] Employee_Department
        [InverseProperty("Employees")]

        public virtual Department EmployeeDepartment { get; set; }
    }
}
