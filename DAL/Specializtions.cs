//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Specializtions
    {
        public Specializtions()
        {
            this.Courses = new HashSet<Courses>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> DepId { get; set; }
    
        public virtual Departments Departments { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
    }
}