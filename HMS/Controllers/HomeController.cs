using HMS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace HMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult More()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View(new Contact { Name = "year2" , Email = "ulk@ac.rw" , Message = "Welcoem to the portal" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }

            TempData["ContactSuccess"] = "Your message has been sent successfully.";
            return RedirectToAction(nameof(Contact));
        }

        public IActionResult Customer()
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
