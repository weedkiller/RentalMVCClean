﻿using RentalMobile.Model.Models;

namespace RentalMobile.Helpers.Identity.Abstract.Roles.PublicProfile
{
    public interface ISpecialistPublicProfileHelper
    {
        string GetTeamPrimaryPhoto(int id);
        string GetSpecialistPrimaryPhoto(int id);
        string GetSpecialistName(int id);
        int GetTotalAvailableZoneSpotForProvider(int providerId);
        Specialist GetPublicProfileSpecialistBySpecialistId(int id);

        void ShareSpecialist(Specialist s);
        string SocialTitleBuilding(Specialist s);
        string GetSpecialistCommentCount(int id);
        string GetSpecialistPrimaryWorkPhoto(int id);
        dynamic SpecialPublicProfileComposeForwardToFriendEmail(string friendname, string friendemailaddress, string message, int id);
    }
}