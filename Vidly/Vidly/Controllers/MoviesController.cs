using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{
		//
		// GET: /Movies/Random
		public ActionResult Random()
		{
			var movie = new Movie() { Name = "Shrek!" };

            //Create a list of Customers
            var customers = new List<Customer>
            {
                //Add two customer objects here
                new Customer { Name="Customer 1"},
                new Customer { Name="Customer 2"}
            };

            var viewmodel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers  
            };

			return View(viewmodel);
		}

        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);
        }
	}
}