using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstMVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Name = "movie 1"
            };
            List<Movie> movies = new List<Movie>()
            {
            new Movie{Name="movie 2"},
            new Movie{Name="movie 3"},
            };
            return View(movies);
        }

        public IActionResult Edit(int id)
        {
            return Content("Test Id" + id);
        }

        public IActionResult ByRelease(int month, int year)
        {
            return Content( "Month " + month + " Year " + year );
        }


        public IActionResult details()
        {
            Movie movie = new Movie()
            {
                Name = "movie 1"
            };
            List<Customer> customers = new List<Customer>()
            {
            new Customer { Id = 1, Name = "Client 1" },
            new Customer { Id = 2, Name = "Client 2" },
            };

            MovieViewModel viewModel = new MovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        /* public IActionResult CustomerDetails(int customerId)
        {
            var customer = viewModel.Customers.FirstOrDefault(c => c.Id == customerId);

            if (customer == null)
            {
                return NotFound(); 
            }

            return View(customer);
        } */


    }
}
