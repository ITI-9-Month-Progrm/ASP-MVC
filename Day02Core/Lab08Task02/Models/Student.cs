﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace Lab08Task02.Models
{
    public partial class Student
    {
        public Student()
        {
            InverseSt_superNavigation = new HashSet<Student>();
        }

        public int St_Id { get; set; }
        public string St_Fname { get; set; }
        public string St_Lname { get; set; }
        public string St_Address { get; set; }
        public int? St_Age { get; set; }
        public int? Dept_Id { get; set; }
        public int? St_super { get; set; }

        public virtual Student St_superNavigation { get; set; }
        public virtual ICollection<Student> InverseSt_superNavigation { get; set; }
    }
}