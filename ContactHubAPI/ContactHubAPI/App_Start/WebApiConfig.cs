using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Cors;

namespace ContactHubAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            EnableCORS(config);
            // Web API routes
            config.MapHttpAttributeRoutes();
            //Json Format
            SetJsonFormatter(config);
            //Routing
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        public static void SetJsonFormatter(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        public static void EnableCORS(HttpConfiguration config)
        {
            var Cors = new EnableCorsAttribute(origins:"*",headers:"*",methods:"*",exposedHeaders:"*");
            config.EnableCors(Cors);
        }
    }
}
