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
    
    public partial class MaintenanceExterior
    {
        public int CompanyId { get; set; }
        public bool Asphalt_Paving { get; set; }
        public bool Awnings { get; set; }
        public bool Concrete_Installation___Repair { get; set; }
        public bool Decks__Patios___Enclosures { get; set; }
        public bool Fence_Install_and_Repair { get; set; }
        public bool Gutter_Services { get; set; }
        public bool Hurricane_Shutter_Systems { get; set; }
        public bool Interlocking___Stonework { get; set; }
        public bool Ironwork___Wrought_Iron { get; set; }
        public bool Landscaping_Installation { get; set; }
        public bool Lawn_Care { get; set; }
        public bool Masonry_and_Brick_Work { get; set; }
        public bool Power_Washing { get; set; }
        public bool Roofing_Services { get; set; }
        public bool Siding { get; set; }
        public bool Skylights { get; set; }
        public bool Sprinkler_Systems_and_Irrigation { get; set; }
        public bool Stucco___Plaster { get; set; }
        public bool Swimming_Pool_Install { get; set; }
        public bool Tree_Service { get; set; }
        public bool Waterproofing { get; set; }
        public bool Windows___Exterior_Doors { get; set; }
    
        public virtual MaintenanceCompanyLookUp MaintenanceCompanyLookUp { get; set; }
    }
}
