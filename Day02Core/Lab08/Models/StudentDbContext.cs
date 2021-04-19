using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab08.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
    }
}
