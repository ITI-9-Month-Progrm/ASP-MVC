using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }
        [ForeignKey("CustID")]
        public int CustID { get; set; }
    }

}