using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using VignyWebApplication.Models;

namespace VignyWebApplication.Controllers
{
	public class CustomersController : Controller
	{
		private MyDBContext _context;

		public CustomersController()
		{
			_context = new MyDBContext();
		}
		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}
		public ViewResult Index()
		{
			var customers = _context.Customers.Include(c => c.MembershipType).ToList();

			return View(customers);
		}

		public ActionResult Details(int id)
		{
			var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

			if (customer == null)
				return HttpNotFound();

			return View(customer);
		}

	}
}