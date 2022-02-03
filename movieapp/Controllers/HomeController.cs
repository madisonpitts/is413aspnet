using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieapp.Models;
using System.Linq;

namespace movieapp.Controllers
{
    public class HomeController : Controller
    {
      
        
        private movieContext movieContext { get; set; }

        public HomeController(movieContext someName)
        {
            movieContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }
        public IActionResult Form()
        {
            ViewBag.categories =  movieContext.categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Form(formResponse fr)
        {
            if (ModelState.IsValid)
            {
                movieContext.Add(fr);
                movieContext.SaveChanges();

                return View("Movies", fr);
            }
            else
            {
                ViewBag.categories = movieContext.categories.ToList();
                return View(fr);
            }
        }

        [HttpGet]
        public IActionResult MovieList ()
        {
            var movieslist = movieContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movieslist);
        }
        [HttpGet]
        public IActionResult Edit (int id)
        {
            ViewBag.categories = movieContext.categories.ToList();

            var movie = movieContext.responses.Single(x => x.MovieNumber == id);
            return View("Form", movie);
        }

        [HttpPost]
        public IActionResult Edit (formResponse x)
        {
            movieContext.Update(x);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = movieContext.responses.Single(x => x.MovieNumber == id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(formResponse fr)
        {
            movieContext.responses.Remove(fr);
            movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }


    }
}
