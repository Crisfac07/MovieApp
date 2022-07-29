using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class AppController : Controller
    {
        private static List<MovieViewModel> _movie = new List<MovieViewModel>(); 
        public IActionResult Index()
        {
            return View(_movie);
        }

        public IActionResult AddOrEdit(Guid id)
        {
            var movie = _movie.FirstOrDefault(x=> x.Id== id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult AddOrEdit(MovieViewModel model)
        {
            var movie = _movie.FirstOrDefault(x=> x.Id==model.Id);
            if (ModelState.IsValid)
            {
                if (movie == null)
                {
                    model.Id = Guid.NewGuid();
                    _movie.Add(model);
                    
                }
                else {
                    movie.Name = model.Name;
                    movie.Genre = model.Genre;
                }
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
