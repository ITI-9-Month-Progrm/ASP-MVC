using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Area_Error__Task.Models
{
    [Table("EmployeeInfo")]
    public class Employee
    {
        [Key]
        public int empID { get; set; }
        [Display(Name = "EmployeeName")]
        [Required(ErrorMessage = "Please enter a name!"), MaxLength(30, ErrorMessage = "too long name!!")]
        public string Name { get; set; }
        public string userName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "you must provide a password!")]
        [MinLength(8, ErrorMessage = "password have to be at least 8 chars")]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime joinDate { get; set; }
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter an Email...")]
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public double Salary { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string phoneNumber { get; set; }

    }
}
