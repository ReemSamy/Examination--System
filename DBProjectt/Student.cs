//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBProjectt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.St_Ques_Exam = new HashSet<St_Ques_Exam>();
            this.Stud_Course = new HashSet<Stud_Course>();
        }
    
        public int St_Id { get; set; }
        public string St_Fname { get; set; }
        public string St_Lname { get; set; }
        public string St_UserName { get; set; }
        public string St_Password { get; set; }
        public string St_Phone { get; set; }
        public string St_Address { get; set; }
        public int St_Age { get; set; }
        public Nullable<System.DateTime> St_JoinDate { get; set; }
        public int Dept_Id { get; set; }
    
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<St_Ques_Exam> St_Ques_Exam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stud_Course> Stud_Course { get; set; }
    }
}
