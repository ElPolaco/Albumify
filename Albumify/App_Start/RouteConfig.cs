using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Albumify
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "AlbumDetails",
                url: "album/{author}/{name}",
                defaults: new { controller = "Album", action = "Details" }
            );

            routes.MapRoute(
                name: "AlbumsByAuthor",
                url: "album/{author}",
                defaults: new { controller = "Album", action = "ListByAuthor" }
            );

            routes.MapRoute(
                name: "AlbumsList",
                url: "album",
                defaults: new { controller = "Album", action = "ListAll" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
