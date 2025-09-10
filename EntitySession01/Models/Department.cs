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

        //Nevigation Property
        public Employee? Manager { get; set; } = null!;
    }
}
