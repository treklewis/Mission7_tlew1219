using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_tlew1219.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_tlew1219.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DateApplicationContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, DateApplicationContext name)
        {
            _logger = logger;
            blahContext = name;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public  IActionResult DatingApplication()
        {
            return View("DatingApplication");
        }

        [HttpPost]
        public IActionResult DatingApplication(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(ar);
                blahContext.SaveChanges();
                return View("response", ar);
            }
            else
            {
                return DatingApplication();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
