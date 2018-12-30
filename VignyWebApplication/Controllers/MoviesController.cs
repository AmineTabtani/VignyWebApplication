using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VignyWebApplication.Models;

namespace VignyWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
			var movie = new Movie() { Name="Harry Potter" } ;
            return View(movie);
        }
    }
}