using System.Web.Mvc;
using System.Web.Routing;

namespace POS
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                "LogOff",   
                "{controller}/{action}/{id}",                          
                new { controller = "Account", action = "LogOff", id = UrlParameter.Optional }
            );
        }
    }
}
