using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01.Models
{
    [PrimaryKey(nameof(DeptId))]
    internal class Department
    {

        public int DeptId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string DeptName { get; set; }

        public int? ManagerId { get; set; }

        //Nevigation Property
        [InverseProperty(nameof(Employee.ManagerDept))]

        public Employee? Manager { get; set; } = null!;

        //One to Many
        //[InverseProperty("EmployeeDepartment")]
        [InverseProperty(nameof(Employee.EmployeeDepartment))]

        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
