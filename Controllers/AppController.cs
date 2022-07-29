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

        public IActionResult AddOrEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrEdit(MovieViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Guid.NewGuid();
                _movie.Add(model);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
