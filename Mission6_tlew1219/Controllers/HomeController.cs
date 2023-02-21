using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private DateApplicationContext daContext { get; set; }

        public HomeController(DateApplicationContext name)
        {
            daContext = name;
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
            ViewBag.Categories = daContext.Categories.ToList();

            return View(new ApplicationResponse());
        }

        [HttpPost]
        public IActionResult DatingApplication(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();
                return View("response", ar);
            }
            else
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View(ar);
            }
        }

        [HttpGet]
        public IActionResult MovieList ()
        {
            var movies = daContext.responses
                .Include(x => x.Category)
                //.Where(xx => xx.Rating != "R")
                .OrderBy(x => x.Rating)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit (int applicationid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var application = daContext.responses.Single(x => x.AppliationID == applicationid);

            return View("DatingApplication", application);
        }

        [HttpPost]
        public IActionResult Edit (ApplicationResponse ar)
        {
            daContext.Update(ar);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        public IActionResult Delete ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var application = daContext.responses.Single(x => x.AppliationID == applicationid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            daContext.responses.Remove(ar);
            daContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
