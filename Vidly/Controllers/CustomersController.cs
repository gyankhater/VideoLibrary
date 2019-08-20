using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
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

		//private IEnumerable<Customer> GetCustomers()
		//{
		//	return new List<Customer>
		//				{
		//						new Customer { Id = 1, Name = "John Smith" },
		//						new Customer { Id = 2, Name = "Mary Williams" }
		//				};
		//}
	}
}