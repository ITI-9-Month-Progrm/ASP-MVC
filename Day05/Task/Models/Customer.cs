using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="You should enter name")]
        [MaxLength(30)]
        public string Name { get; set; }
        [MinLength(4)]
        [GenderAnnotation("")]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}