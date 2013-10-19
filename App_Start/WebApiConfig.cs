using System.Web.Http;

namespace LightSwitchApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
             name: "DefaultRpc",
             routeTemplate: "rpc/{controller}/{action}/{id}",
             defaults: new { id = RouteParameter.Optional }
             );
        }
    }
}
