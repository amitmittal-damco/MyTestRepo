//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrmDomain
{
    using System;
    using System.Collections.Generic;
    
    public partial class DBOevent
    {
        public int RecordID { get; set; }
        public Nullable<int> DbID { get; set; }
        public string Company { get; set; }
        public Nullable<System.DateTime> MyDate { get; set; }
        public Nullable<System.DateTime> MyTime { get; set; }
        public Nullable<bool> Run { get; set; }
        public string Status { get; set; }
    }
}
