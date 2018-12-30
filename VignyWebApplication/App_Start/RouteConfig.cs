using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VignyWebApplication
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.MapMvcAttributeRoutes();
			//attribute routes let us define routes in front of methods in controllers
			/*routes.MapRoute(
				 "MoviesByReleaseDate",
				 "{movies}/{released}/{year}/{month}",
				 new { controller = "Movies", action = "ByReleaseDate",},
				 new { year = @"2015|2016|2017|2018", month = @"0[0-9]|1[0-2]" } //@"\d{2}"
			);*/
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
