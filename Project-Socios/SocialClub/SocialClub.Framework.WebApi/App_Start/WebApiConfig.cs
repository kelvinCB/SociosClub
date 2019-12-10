using System.Web.Http;
using System.Web.Http.Cors;


namespace SocialClub.Framework.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
#if DEBUG
            config.EnableCors(new EnableCorsAttribute("http://localhost:5176", "*", "*"));
#endif
            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
