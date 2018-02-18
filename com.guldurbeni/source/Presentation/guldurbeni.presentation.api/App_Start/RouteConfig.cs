using guldurbeni.presentation.api.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace guldurbeni.presentation.api
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var route = routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}"
            );



            foreach(Route item in routes)
            {
                item.RouteHandler = new MyHttpControllerRouteHandler();
            }
            


        }
    }
}
