using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using mission06_Allen.Models;

namespace mission06_Allen.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext _context;
        public HomeController(MovieFormContext temp)//constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Baconsale()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(MovieForm response)
        {
            _context.Movies.Add(response); // the movie to the database
            _context.SaveChanges(); //saves the changes to the database

            return View("Confirmation", response);

        }
        public IActionResult Privacy()
        {
            return View();
        }



       //Tehe this is anthoer github test
    }
}
