using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab08.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Topic { get; set; }
        public int Grade { get; set; }
        public virtual ICollection<Student> Students{get;set;}

    }
}
