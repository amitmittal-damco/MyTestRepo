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
    
    public partial class TempReport
    {
        public int RecordID { get; set; }
        public string DbName { get; set; }
        public string AppVersion { get; set; }
        public string MyGroup { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool MyDate { get; set; }
        public string DateField { get; set; }
        public string Range1 { get; set; }
        public string Field1 { get; set; }
        public Nullable<int> Size1 { get; set; }
        public string Range2 { get; set; }
        public string Field2 { get; set; }
        public Nullable<int> Size2 { get; set; }
        public bool Batch { get; set; }
        public bool Daily { get; set; }
        public bool Weekly { get; set; }
        public bool Monthly { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string StartRange1 { get; set; }
        public string EndRange1 { get; set; }
        public string StartRange2 { get; set; }
        public string EndRange2 { get; set; }
        public bool ToPrint { get; set; }
        public bool ToEmail { get; set; }
        public bool ToFile { get; set; }
        public string EmailAddress { get; set; }
        public string FileName { get; set; }
        public bool AutoGenerateName { get; set; }
        public string FileType { get; set; }
        public Nullable<bool> ToFax { get; set; }
        public string Fax { get; set; }
        public Nullable<System.DateTime> AStartDate { get; set; }
        public Nullable<System.DateTime> AEndDate { get; set; }
        public string AStartRange1 { get; set; }
        public string AStartRange2 { get; set; }
        public string AEndRange1 { get; set; }
        public string AEndRange2 { get; set; }
        public Nullable<System.DateTime> PrintTime { get; set; }
        public Nullable<int> DayofWeek { get; set; }
        public Nullable<int> DayofMonth { get; set; }
        public Nullable<bool> Autobin { get; set; }
        public int DateRange { get; set; }
        public int ADateRange { get; set; }
        public Nullable<bool> Processed { get; set; }
    }
}
