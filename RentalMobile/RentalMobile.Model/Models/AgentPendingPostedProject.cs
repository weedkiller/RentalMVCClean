
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;

namespace RentalMobile.Model.Models
{
    public partial class AgentPendingPostedProject
{

    public int ID { get; set; }

    public int ProjectID { get; set; }

    public Nullable<int> AgentId { get; set; }

    public Nullable<int> SpecialistId { get; set; }

    public int ServiceTypeID { get; set; }

    public Nullable<double> Budget { get; set; }

    public string Currency { get; set; }

    public Nullable<int> CurrencyCode { get; set; }

    public Nullable<System.DateTime> Date { get; set; }

}

}
