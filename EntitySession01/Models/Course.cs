using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Many to Many RS Student_Course
        public ICollection<Student> Students { get; set; } 
    }
}
