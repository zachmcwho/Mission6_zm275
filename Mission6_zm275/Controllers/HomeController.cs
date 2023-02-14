using Microsoft.AspNetCore.Mvc;
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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
