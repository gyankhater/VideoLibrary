using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
		public class MoviesController : Controller
		{

			public ViewResult Index()
			{
				var movies = GetMovies();

				return View(movies);
			}

			private IEnumerable<Movie> GetMovies()
			{
				return new List<Movie>
							{
									new Movie { Id = 1, Name = "Shrek" },
									new Movie { Id = 2, Name = "Wall-e" }
							};
			}

		// GET: Movie
			public ActionResult Random()
				{
					var movie = new Movie()
					{
						Name = "Shrek!"
					};

					var customers = new List<Customer>
					{
						new Customer {Name="John Smith"},
						new Customer {Name="Mary Williams"}
					};

					var viewModel = new RandomMovieViewModel
					{
						Movie = movie,
						Customers = customers
					};

					return View(viewModel);
					//return View(movie);
					//return Content("Hello World!");
					//return HttpNotFound();
					//return new EmptyResult();
					//return RedirectToAction("Index", "Home",new { page = 1, sortBy = "name" });

				}

				//public ActionResult Edit(int id)
				//{
				//	return Content("id=" + id);
				//}

				//public ActionResult Index(int? pageIndex, string sortBy)
				//{
				//	if (!pageIndex.HasValue)
				//		pageIndex = 1;

				//	if (string.IsNullOrWhiteSpace(sortBy))
				//		sortBy = "Name";

				//	return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

				//}


				//public ActionResult ByReleaseDate(int year, int month)
				//{
				//	return Content(year + "/" + month);
				//}

		}
}