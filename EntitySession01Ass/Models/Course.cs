using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01Ass.Models
{
    public class Course
    {
        //using Data Annotations
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? Duration { get; set; }

    
        [Required]
        [MaxLength(50, ErrorMessage = "Name Must be Less Than 51 char !")]
        [MinLength(3, ErrorMessage = "Name Must be Greater Than 3 char !")]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        public int? Top_ID { get; set; }
    }
}
