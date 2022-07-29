using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddOrEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrEdit(Guid id)
        {
            return View();
        }
    }
}
