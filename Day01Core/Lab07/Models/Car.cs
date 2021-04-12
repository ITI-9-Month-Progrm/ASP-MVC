using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab07.Models
{
    public class Car
    {
        [Key]
        public int Num { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Manfacture { get; set; }
        
    }
}
