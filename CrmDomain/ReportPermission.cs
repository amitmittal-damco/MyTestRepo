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
    
    public partial class ReportPermission
    {
        public long id { get; set; }
        public int permissionID { get; set; }
        public long reportID { get; set; }
        public Nullable<long> groupID { get; set; }
        public Nullable<long> accountID { get; set; }
        public Nullable<long> companyID { get; set; }
    }
}
