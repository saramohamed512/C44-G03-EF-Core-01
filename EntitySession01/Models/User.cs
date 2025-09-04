using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession01.Models
{
    [Table("Users")]
    internal class User
    {
        //Data Annotation
        [Key]
        public int SSN { get; set; }
        [Required]
        [Column("UserName", TypeName = "varChar(50)")]
        [MaxLength(50,ErrorMessage = "Name Must be Less Than 51 char !")]
        [MinLength(3, ErrorMessage = "Name Must be Greater Than 3 char !")]
        [StringLength(maximumLength:50, MinimumLength =3)]
        public string UName { get; set; }
        [Required]
        [Range(20,50)]
        public int Age { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        public int MyProperty { get; set; }
    }
}
