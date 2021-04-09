using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task03.Models
{
    public class MainDbContext:DbContext
    {
        public MainDbContext() : base("DBConnection") { }
        public virtual DbSet<Client> Clients { get; set; }
    }
}