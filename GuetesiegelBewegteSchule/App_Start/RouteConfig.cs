using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GuetesiegelBewegteSchule
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Start", id = UrlParameter.Optional }
            );

            //routes.MapRoute(
            //    name: "PunkteUnterrichtsqualitaet",
            //    url: "{punkte_U}",
            //    defaults: new { Controller = "Home", action = "Uebersicht" }
            //);
        }
    }
}
