//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ICTManagementTool.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Students()
        {
            this.StudentCourses = new HashSet<StudentCourses>();
            this.StudentProjectRanking = new HashSet<StudentProjectRanking>();
        }
    
        public int studentID { get; set; }
        public string uniUserName { get; set; }
        public string uniStudentID { get; set; }
        public Nullable<decimal> gpa { get; set; }
        public int year { get; set; }
        public string semester { get; set; }
        public Nullable<System.DateTime> dateEnded { get; set; }
        public int planId { get; set; }
        public string genderCode { get; set; }
        public string international { get; set; }
        public string studentEmail { get; set; }
        public bool externalStudent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        protected virtual ICollection<StudentCourses> StudentCourses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        protected virtual ICollection<StudentProjectRanking> StudentProjectRanking { get; set; }
        public virtual Plans Plans { get; set; }
        public virtual Plans Plans1 { get; set; }
    }
}