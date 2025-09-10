using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Department? ManagerDept { get; set; } = null!;

        public Adress EmpAdress { get; set;  }= null!;
    }
}
