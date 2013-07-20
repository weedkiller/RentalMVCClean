//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalMobile.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GeneratedRentalContract
    {
        public int ID { get; set; }
        public string LandLoardName { get; set; }
        public string LandLoardRole { get; set; }
        public Nullable<int> LandLoradID { get; set; }
        public string LandLoardAddress { get; set; }
        public string TenantName { get; set; }
        public Nullable<int> TenantID { get; set; }
        public Nullable<int> PropertyID { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyCity { get; set; }
        public Nullable<double> MonthlyRent { get; set; }
        public int? BeginingDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<double> FirstMonthRent { get; set; }
        public Nullable<double> SecurityDeposit { get; set; }
        public Nullable<double> TotalPayment { get; set; }
        public Nullable<int> TenantRefundedNumberofDays { get; set; }
        public Nullable<int> NoticeofMoveoutNumberofDays { get; set; }
        public Nullable<double> LateFeeCharge { get; set; }
        public Nullable<int> PercentageofLateFeeCharge { get; set; }
        public Nullable<int> LateFeeStartingDay { get; set; }
        public string ExceptedUtilites { get; set; }
        public Nullable<double> PetDeposit { get; set; }
        public Nullable<double> PetMonthly { get; set; }
        public string ParkingSpaceNumber { get; set; }
        public Nullable<double> ParkingFee { get; set; }
    }
}
