
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace RentalMobile.Model.Models
{
    public partial class TenantShowing
{

    public int ShowingId { get; set; }

    public System.DateTime Date { get; set; }

    public int UnitId { get; set; }

    public int TenantId { get; set; }



    public virtual Tenant Tenant { get; set; }

}

}
