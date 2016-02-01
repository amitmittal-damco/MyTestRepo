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
    
    public partial class Databas
    {
        public int DbID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> AccountID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public string Company { get; set; }
        public string DsnName { get; set; }
        public string DbSchema { get; set; }
        public string DbName { get; set; }
        public string DbLogin { get; set; }
        public string DbPassword { get; set; }
        public Nullable<bool> AutoPO { get; set; }
        public Nullable<bool> Live { get; set; }
        public Nullable<bool> Notify { get; set; }
        public Nullable<bool> Monitor { get; set; }
        public Nullable<int> NumOfCribs { get; set; }
        public Nullable<int> LastMonthNumOfCribs { get; set; }
        public Nullable<System.DateTime> FirstTransaction { get; set; }
        public Nullable<bool> UseMasterItem { get; set; }
        public Nullable<bool> LocalDBType { get; set; }
        public string LocalVersion { get; set; }
        public Nullable<bool> AllowDomainName { get; set; }
        public Nullable<bool> MultiSync { get; set; }
        public Nullable<int> LCID { get; set; }
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public Nullable<bool> OwnedBy { get; set; }
        public Nullable<bool> UseCustomPOReport { get; set; }
        public string CustomerFolderPath { get; set; }
        public string ASPSyncStatus { get; set; }
        public string AutoPollStatus { get; set; }
        public Nullable<System.DateTime> LastSyncTime { get; set; }
        public string SalesOrderNumber { get; set; }
        public Nullable<bool> UseBackgroundImage { get; set; }
        public Nullable<bool> UseCustomedImages { get; set; }
        public string HeaderTextColor { get; set; }
        public string SearchHighlightColor { get; set; }
        public Nullable<float> CurrentSize { get; set; }
        public Nullable<float> MaximumSize { get; set; }
        public string RemoteType { get; set; }
        public string RemoteIP { get; set; }
        public string RemoteLogin { get; set; }
        public string RemotePassword { get; set; }
        public string RemotePath { get; set; }
        public string Notes { get; set; }
        public Nullable<bool> Setup_Company { get; set; }
        public Nullable<bool> Setup_Defaults { get; set; }
        public Nullable<bool> Setup_Connection { get; set; }
        public Nullable<bool> Setup_Locations { get; set; }
        public Nullable<bool> Setup_Controller { get; set; }
        public Nullable<bool> Setup_Terminals { get; set; }
        public Nullable<bool> Setup_Logins { get; set; }
        public Nullable<bool> Setup_Cribs { get; set; }
        public Nullable<bool> Setup_Bins { get; set; }
        public Nullable<bool> Setup_Inventory { get; set; }
        public Nullable<bool> Setup_Databases { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> NewSync { get; set; }
        public bool Webservice { get; set; }
        public bool BackupOnly { get; set; }
        public bool MX { get; set; }
        public Nullable<int> NumOfBins { get; set; }
        public Nullable<int> LastMonthNumOfBins { get; set; }
        public bool WebserviceBeforeSuspend { get; set; }
        public Nullable<int> AccountType { get; set; }
        public Nullable<int> BillFrequency { get; set; }
        public int OutboxRecords { get; set; }
        public bool DoNotDelete { get; set; }
        public bool SharedSecret { get; set; }
    }
}
