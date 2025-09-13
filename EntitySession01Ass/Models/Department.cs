using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01Ass.Models
{
    public class Department
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Ins_ID { get; set; }
        public DateTime? HiringDate { get; set; }
        //public virtual Instructor Instructor { get; set; }
        public Instructor Manager { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();
    }
}
