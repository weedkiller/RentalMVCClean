
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
    public partial class UnitAppliance
{

    public int UnitId { get; set; }

    public bool Range_Oven { get; set; }

    public bool Full_Refrigerator { get; set; }

    public bool Dishwasher { get; set; }

    public bool Sink_Disposal { get; set; }

    public bool Microwave { get; set; }

    public bool Central_Vacuum { get; set; }

    public bool Surround_Sound { get; set; }

    public bool Wine_Fridge { get; set; }

    public bool Washer___Dryer_in_Unit { get; set; }

    public bool Washer_Dryer_Connections { get; set; }

    public bool Shared_Laundry_Facility { get; set; }



    public virtual Unit Unit { get; set; }

}

}
