﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RentalMobile
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");




            //Professional/{Id} 
            routes.MapRoute(
                "ProfessionalView",
                "Professionals/{id}",
                new { controller = "Professionals", action = "Index",  id = UrlParameter.Optional }
            );

            //Providers/{Id} 
            routes.MapRoute(
                "ProvidersView",
                "Providers/{id}",
                new { controller = "Providers", action = "Index", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );







            
            //Need to add new route for property/id
            //routes.MapRoute("Property", "Property/{id}",
            //             new { controller = "Property", action = "Index" });



            //OwnerProject
           // routes.MapRoute(
           //  "Owner",
           //  "ArchivedProject/View",
           //  new { Controller = "Owner", action = "ViewArchivedProject" });

           // routes.MapRoute(
           //"Owner",
           //"ArchivedProject/Delete",
           //new { Controller = "Owner", action = "ViewArchivedProject" });
        }

        protected void Application_Start()
        {

            ViewEngines.Engines.Add(new MobileViewEngine());
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}