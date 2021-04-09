using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task03.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string ClientName { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Confirm_Password { get; set; }
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        }

}