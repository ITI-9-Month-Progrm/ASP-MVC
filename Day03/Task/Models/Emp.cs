//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emp()
        {
            this.Cities = new HashSet<City>();
        }
    
        public int EmpID { get; set; }
        public string EmpFname { get; set; }
        public string EmpLname { get; set; }
        public Nullable<double> EmpSalary { get; set; }
        public Nullable<System.DateTime> EmpHDate { get; set; }
        public int dID { get; set; }
        public Nullable<int> CtyID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<City> Cities { get; set; }
        public virtual Dept Dept { get; set; }
    }
}
