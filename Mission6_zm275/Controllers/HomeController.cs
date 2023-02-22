using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6_zm275.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_zm275.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private FilmApplication _ApplicationContext { get; set; }
        public HomeController(ILogger<HomeController> logger, FilmApplication someName)
        {
            _logger = logger;
            _ApplicationContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = _ApplicationContext.Categories.ToList();
            FormModel model = new FormModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Form(FormModel fm)
        {
             // return a confirmation
                _ApplicationContext.Add(fm);
                _ApplicationContext.SaveChanges();

                return View("Confirmation", fm);
            
        }

        [HttpGet]
        public IActionResult Movies()
        {
            var movieList = _ApplicationContext.Responses.Include(x => x.Category)
                .ToList();
            return View(movieList);
        }
        // adds edit ability
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _ApplicationContext.Categories.ToList();
            FormModel form = _ApplicationContext.Responses.Single(i => i.FormId == id);
           
            return View("Form", form);
        }
        [HttpPost]

        public IActionResult Edit(FormModel fm)
        {
            _ApplicationContext.Update(fm);
            _ApplicationContext.SaveChanges();

            return RedirectToAction("Movies");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            FormModel delete = _ApplicationContext.Responses.Single(i => i.FormId == id);
            return View(delete);
        }
        [HttpPost]
        public IActionResult Delete(FormModel fm)
        {
            _ApplicationContext.Remove(fm);
            _ApplicationContext.SaveChanges();
            return RedirectToAction("Movies");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
