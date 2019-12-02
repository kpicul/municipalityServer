using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Municipalities
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Municipalities",
                routeTemplate: "municipalities/{id}",
                defaults: new { controller = "municipalities", id = RouteParameter.Optional}
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
