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
        // GET: Movies
        public ActionResult Random()
        {
            var randomMovie = new RandomMovieViewModel
            {
                Movie = new Movie
                {
                    Name = "Shrek"
                },
                Customers = new List<Customer> {
                    new Customer { Name = "George" },
                    new Customer { Name = "Jane" }
                }
            };
            return View(randomMovie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}