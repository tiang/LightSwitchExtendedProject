using System.Web.Mvc;
using System.Web.Routing;

namespace LightSwitchApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*allsvc}", new { allsvc = @".*\.svc(/.*)?" });

            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Home", action = "index" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

