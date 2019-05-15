using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Gerenciador {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "repositorio1",
                "repositorio1",
                defaults: new { controller = "Home", action = "Repo1", id = UrlParameter.Optional });

            routes.MapRoute(
                "repositorio2",
                "repositorio2",
                defaults: new { controller = "Home", action = "Repo2", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
