//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentalMobile.Model.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProviderProfileComment
    {
        public int CommentId { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public Nullable<int> PosterId { get; set; }
        public Nullable<int> PosterRole { get; set; }
        public string PosterName { get; set; }
        public string PosterPhotoPath { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
        public string PosterProfileLink { get; set; }
    }
}
