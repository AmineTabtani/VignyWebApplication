using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VignyWebApplication.Models;
using VignyWebApplication.ViewModels;

namespace VignyWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
		//ActionResult <-- ViewResult
        public ActionResult Random()
        {
			var movie = new Movie() { Name="Harry Potter" } ;
			var customers = new List<Customer>
			{
				new Customer{Name="Customer 1"},
				new Customer{Name="Customer 2"}
			};
			var viewModel = new RandomMovieViewModel
			{
				Movie = movie,
				Customers = customers
			};
			return View(viewModel);
			//return new ViewResult(); //we use helper method of Controller View insead
			//return Content("Hello Amine");
			//return HttpNotFound();
			//return new EmptyResult(); // if we dont want to return anything
			//return RedirectToAction("Index", "Home",new {page=1, sortBy="Name" }); //RedirectToAction( action, controller, parameter)
		}
		//movies
		public ActionResult Index(int? pageIndex,string sortBy )
		{
			if (!pageIndex.HasValue)
				pageIndex = 1;
			if (String.IsNullOrWhiteSpace(sortBy))
				sortBy = "Name";
			return Content(String.Format("PageIndex={0} & SortBy={1}",pageIndex,sortBy));
		}
		[Route("movies/released/{year:regex(\\d{4}):range(1990,2020)}/{month:regex(\\d{2}):range(1,12)}")]
		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content(year+" / "+month);
		}
	}
}