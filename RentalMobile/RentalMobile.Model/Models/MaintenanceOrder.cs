
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
    
public partial class MaintenanceOrder
{

    public MaintenanceOrder()
    {

        this.MaintenancePhotoes = new HashSet<MaintenancePhoto>();

        this.OwnerMaintenances = new HashSet<OwnerMaintenance>();

        this.MaintenanceCrews = new HashSet<MaintenanceCrew>();

    }


    public int MaintenanceID { get; set; }

    public int UnitID { get; set; }

    public System.DateTime MaintenanceDate { get; set; }

    public int UrgencyID { get; set; }

    public string Description { get; set; }

    public int ServiceTypeID { get; set; }

    public bool PetsinUnit { get; set; }

    public bool TenantPresence { get; set; }



    public virtual ServiceType ServiceType { get; set; }

    public virtual UrgencyType UrgencyType { get; set; }

    public virtual ICollection<MaintenancePhoto> MaintenancePhotoes { get; set; }

    public virtual ICollection<OwnerMaintenance> OwnerMaintenances { get; set; }

    public virtual TenantMaintenance TenantMaintenance { get; set; }

    public virtual ICollection<MaintenanceCrew> MaintenanceCrews { get; set; }

}

}