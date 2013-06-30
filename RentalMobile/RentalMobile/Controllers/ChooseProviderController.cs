﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentalMobile.Helpers;
using RentalMobile.Models;

namespace RentalMobile.Controllers
{
    [Authorize]
    public class ChooseProviderController : Controller
    {
        private DB_33736_rentalEntities db = new DB_33736_rentalEntities();


        public ViewResult Index(int providerid)
        {
            var provider = db.MaintenanceProviders.Find(UserHelper.GetProviderID((Convert.ToInt32(providerid))));
            ViewBag.providerProfile = provider;
            ViewBag.providerId = provider.MaintenanceProviderId;
            ViewBag.providerGoogleMap = provider.GoogleMap;



            //If Tenant is log on
            var tenant = db.Tenants.Find(UserHelper.GetTenantID());
            ViewBag.TenantName = tenant.FirstName + " " + tenant.LastName;
            ViewBag.TenantEmail = tenant.EmailAddress;


            //Tenant Telephone not required



            TempData["providerid"] = providerid;

            return View(provider);
        }


















        //public ActionResult Hire()
        //{
        //    return View();
        //}

         //public ActionResult Index(string propertyIdcustom, string providerid)

        //   public ActionResult Select(string propertyIdcustom, string providerid, FormCollection collection)


        public ActionResult Submit()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Submit(string propertyIdcustom)
        {

            var startdate = TempData["startDate"];
            var endate = TempData["endDate"];
            var providerid = TempData["providerid"];


                ////PROCESS TO AMAZONPAYPAL
                ////YOU DON'T NEED MODEL VALIDATION

                ////ALSO WHEN SUCCED
                ////ADD ROW IN PAYMENT WITH DESCRIPTION OF THIS TRANSACTION

                ////ALSO SEND EMAIL TO LISTER
                ////SO HE OR SHE DOES BACKGROUND CHECKING AND ACCPET/DENY JOB OFFER



                //Tenant propose job for the provider
                //It will in pending jobs for provider
                //If provider accept
                //Notify Tenant, OWner, PRovider
                //Generate Contracts for all


                var provider = db.MaintenanceProviders.Find(UserHelper.GetProviderID((Convert.ToInt32(providerid))));
                var tenant = db.Tenants.Find(UserHelper.GetTenantID());

                //Property
                var propertyId = (Convert.ToInt32(propertyIdcustom));
                var property = db.Units.FirstOrDefault(t => t.UnitId == propertyId);
                if (property == null)
                {
                    return RedirectToAction("Index");
                }


                InsertPendingJobOffer(provider.MaintenanceProviderId, tenant, propertyId, (DateTime) startdate,(DateTime) endate);
                ViewData["confirmationmsg"] = "Your Application had been succesfully submitted to the Provider.";
                return View(provider);




        }


        [HttpPost]
        public ActionResult Select(FormCollection form)
        {

            TempData["startDate"] = form["HiddenStartDate"];
            TempData["endDate"] = form["HiddenEndDate"];

            //QueryString
           // TempData["providerid"] = Url.RequestContext.RouteData.Values["providerid"].ToString();

           // TempData["UserID"] = UserHelper.GetTenantID();
            //form["ProviderId"] from url
            //from["PropertyId"] this we have tocreate a new view
     
            //return RedirectToAction("Index", new { providerid = 0 });

            return RedirectToAction("Submit");








            //form["HiddenStart"]
            //form["HiddenEnd"]

            //Tenant
            // var tenant = db.Tenants.Find(UserHelper.GetTenantID());

            //Provider
            //var provider = db.MaintenanceProviders.Find(UserHelper.GetProviderID((Convert.ToInt32(providerid))));

        }





        //[HttpPost]
        //public ActionResult Select()
        //{

        //    ////PROCESS TO AMAZONPAYPAL
        //    ////YOU DON'T NEED MODEL VALIDATION

        //    ////ALSO WHEN SUCCED
        //    ////ADD ROW IN PAYMENT WITH DESCRIPTION OF THIS TRANSACTION

        //    ////ALSO SEND EMAIL TO LISTER
        //    ////SO HE OR SHE DOES BACKGROUND CHECKING AND ACCPET/DENY APPLICATION

        //    ////Insert into Owner/Agent Pending Application when Application payment is complete 
        //    ////var f = db.Units.Where(t=>t.)

        //    ////WHEN AMAZON PAYMENT SUCCEED
        //    //if (property != null)
        //    //{
        //    //    var posterrole = property.PosterRole.Trim();

        //    //    switch (posterrole)
        //    //    {

        //    //        case "Owner":
        //    //            //Insert into Pending Application
        //    //            if (property.PosterID != null)
        //    //                InsertOwnerPendingApplication(tenantrentalapplication.First(), (int)property.PosterID);
        //    //            ViewData["confirmationmsg"] = "Your Application had been succesfully submitted to the Owner.";

        //    //            //Confirmation that is has been posted
        //    //            break;

        //    //        case "Agent":
        //    //            //Insert into Pending Application
        //    //            if (property.PosterID != null)
        //    //                InsertAgentPendingApplication(tenantrentalapplication.First(), (int)property.PosterID);
        //    //            ViewData["confirmationmsg"] = "Pass";
        //    //            break;

        //    //    }
        //    //}











        //    //Tenant propose job for the provider
        //    //It will in pending jobs for provider
        //    //If provider accept
        //    //Notify Tenant, OWner, PRovider
        //    //Generate Contracts for all


        //    var provider = db.MaintenanceProviders.Find(UserHelper.GetProviderID((Convert.ToInt32(providerid))));


        //    var tenant = db.Tenants.Find(UserHelper.GetTenantID());

        //    //Property
        //    var propertyId = (Convert.ToInt32(propertyIdcustom));
        //    var property = db.Units.FirstOrDefault(t => t.UnitId == propertyId);
        //    if (property == null)
        //    {
        //        return RedirectToAction("Index");
        //    }

        //    InsertPendingJobOffer(provider.MaintenanceProviderId, tenant, propertyId);

        //    return View(provider);



        //}


        protected void InsertPendingJobOffer(int providerid, Tenant tenant, int propertyid, DateTime startDate, DateTime endDate)
        {
            var provider = db.MaintenanceProviders.FirstOrDefault(t => t.MaintenanceProviderId == (Convert.ToInt32(providerid)));
            if (provider == null) return;
            //var opa = new OwnerPendingApplication
            var mpj = new MaintenanceProviderNewJobOffer()
                {
                    TenantId = tenant.TenantId,
                    TenantName = tenant.FirstName + " " + tenant.LastName,
                    TenantEmailAddress = tenant.EmailAddress,
                    PropertyId = propertyid,
                    StartDate = startDate,
                    EndDate = endDate
                };
            db.MaintenanceProviderNewJobOffers.Add(mpj);
            db.SaveChanges();
            ViewData["confirmationmsg"] = "Your Application had been succesfully submitted to the Owner.";
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
