﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MultiLanguageYeniCodeFirst
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "LocalizedDefault",
                url: "{lang}/{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" },
                constraints: new { lang = "en|tr" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index", lang = "en" }
            );
        }
    }
}
