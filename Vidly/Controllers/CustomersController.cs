using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> Customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John" },
            new Customer { Id = 2, Name = "Kate" }
        };
        // GET: Customers
        public ActionResult Index()
        {
            return View(Customers);
        }

        public ActionResult Details(int id)
        {
            var customer = Customers.Find(c => c.Id == id);
            return View(customer);
        }
    }
}