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
    
    public partial class OwnerAcceptedApplication
    {
        public int ApplicationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string DriverLicense { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
        public string CoSignerName { get; set; }
        public string CoSignerAddress { get; set; }
        public string CoSignerCity { get; set; }
        public string CoSignerState { get; set; }
        public string CoSignerZipcode { get; set; }
        public string CoSignerPhone { get; set; }
        public string CoSignerRelationShip { get; set; }
        public string CoSignerEmailAddress { get; set; }
        public string OtherOccupant1Name { get; set; }
        public Nullable<bool> IsOccupant1Adult { get; set; }
        public string RelationshipOccupant1ToApplicant { get; set; }
        public string OtherOccupant2Name { get; set; }
        public Nullable<bool> IsOccupant2Adult { get; set; }
        public string RelationshipOccupant2ToApplicant { get; set; }
        public string OtherOccupant3Name { get; set; }
        public Nullable<bool> IsOccupant3Adult { get; set; }
        public string RelationshipOccupant3ToApplicant { get; set; }
        public string OtherOccupant4Name { get; set; }
        public Nullable<bool> IsOccupant4Adult { get; set; }
        public string RelationshipOccupant4ToApplicant { get; set; }
        public string EmployerName { get; set; }
        public string Income { get; set; }
        public Nullable<System.DateTime> WorkStartDate { get; set; }
        public Nullable<System.DateTime> WorkEndDate { get; set; }
        public string EmployerAddress { get; set; }
        public string EmployerCity { get; set; }
        public string EmployerState { get; set; }
        public string EmployerZipcode { get; set; }
        public string EmployerPhone { get; set; }
        public string EmployerFax { get; set; }
        public string CurrentLandloard { get; set; }
        public string CurrentLandLoardPhone { get; set; }
        public string CurrentLandLoardFax { get; set; }
        public string CurrentAddress { get; set; }
        public string CurrentAddressCity { get; set; }
        public string CurrentAddressState { get; set; }
        public string CurrentAddressZip { get; set; }
        public string Rent { get; set; }
        public Nullable<System.DateTime> CurrentRentStartDate { get; set; }
        public Nullable<System.DateTime> CurrentRentEndDate { get; set; }
        public string PreviousLandloard { get; set; }
        public string PreviousLandLoardPhone { get; set; }
        public string PreviousLandLoardFax { get; set; }
        public string PreviousAddress { get; set; }
        public string PreviousAddressCity { get; set; }
        public string PreviousAddressState { get; set; }
        public string PreviousAddressZip { get; set; }
        public string PreviousRent { get; set; }
        public Nullable<System.DateTime> PreviousRentStartDate { get; set; }
        public Nullable<System.DateTime> PreviousRentEndDate { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactRelationShip { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string EmergencyContactAddress { get; set; }
        public string EmergencyContactCity { get; set; }
        public string EmergencyContactState { get; set; }
        public string EmergencyContactZipCode { get; set; }
        public Nullable<bool> Pets { get; set; }
        public Nullable<int> PetsNumber { get; set; }
        public string Pet1Brand { get; set; }
        public Nullable<int> Pet1Age { get; set; }
        public string Pet1Weight { get; set; }
        public string Pet2Brand { get; set; }
        public Nullable<int> Pet2Age { get; set; }
        public string Pet2Weight { get; set; }
        public string Vehicle1Make { get; set; }
        public string Vehicle1Model { get; set; }
        public Nullable<int> Vehicle1Year { get; set; }
        public string Vehicle1Color { get; set; }
        public string Vehicle1LicensePlate { get; set; }
        public string Vehicle2Make { get; set; }
        public string Vehicle2Model { get; set; }
        public Nullable<int> Vehicle2Year { get; set; }
        public string Vehicle2Color { get; set; }
        public string Vehicle2LicensePlate { get; set; }
        public string Vehicle3Make { get; set; }
        public string Vehicle3Model { get; set; }
        public Nullable<int> Vehicle3Year { get; set; }
        public string Vehicle3Color { get; set; }
        public string Vehicle3LicensePlate { get; set; }
        public string Vehicle4Make { get; set; }
        public string Vehicle4Model { get; set; }
        public Nullable<int> Vehicle4Year { get; set; }
        public string Vehicle4Color { get; set; }
        public string Vehicle4LicensePlate { get; set; }
        public Nullable<bool> Bankruptcy { get; set; }
        public Nullable<bool> LeaseDefaulted { get; set; }
        public Nullable<bool> RefusedtoPayRent { get; set; }
        public Nullable<bool> EvictedFromRental { get; set; }
        public Nullable<bool> ConvictedofFelony { get; set; }
        public Nullable<int> TenantId { get; set; }
        public int OwnerId { get; set; }
    }
}
