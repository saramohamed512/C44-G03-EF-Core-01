using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01Ass.Models
{
    [PrimaryKey(nameof(inst_ID), nameof(course_ID))]
    public class Course_Inst
    {
        public int inst_ID { get; set; }
        public int course_ID { get; set; }
        [MaxLength(200)]
        public string evaluate { get; set; }

        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
