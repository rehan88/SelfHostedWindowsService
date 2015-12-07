﻿using System.Web.Http;

namespace WindowsServiceSelfHosted.Configs
{
    namespace Configs
    {
        public static class RoutesConfig
        {
            public static void MapDefinedRoutes(this HttpConfiguration config)
            {
                config.Routes.MapHttpRoute
                (
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new
                    {
                        id = RouteParameter.Optional
                    }
                );
            }
        }
    }
}