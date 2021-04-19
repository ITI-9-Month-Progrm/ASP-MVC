using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab08.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public Gender Gender { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        [DataType(DataType.PhoneNumber)]
        public string PhoneNum { get; set; }
        [DataType(DataType.Date)]
        public string Birthdate { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

    }
}
