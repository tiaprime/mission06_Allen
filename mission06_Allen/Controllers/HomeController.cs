using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using mission06_Allen.Models;
using static System.Net.Mime.MediaTypeNames;

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
        [HttpGet]
        public IActionResult SeeMovies()
        {
            //linq
            var movies = _context.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName)
            .ToList();
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



        //LET HANDEL EDITS
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                 .Single(x => x.MovieId == id);

            ViewBag.Crafts = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("Form", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieForm updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("SeeMovies");
        }



    }
}
