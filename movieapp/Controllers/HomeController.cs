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
            movieContext.Add(fr);
            movieContext.SaveChanges();

            return View("Movies", fr);
        }

        [HttpGet]
        public IActionResult WaitList ()
        {
            var movieslist = movieContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();

            return View(movieslist);
        }

   


    }
}
