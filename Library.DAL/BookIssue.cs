//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookIssue
    {
        public int ID { get; set; }
        public Nullable<int> BookID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Student Student { get; set; }
    }
}