using HMS.Data;
using HMS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Models;

namespace HMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly App_Db_Contacts _context;

        public HomeController(App_Db_Contacts context)
        {
            _context = context;
        }

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
            return View(new Contact());
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

        public async Task<IActionResult> Patient()
        {
            var patients = await _context.Patients
                .AsNoTracking()
                .ToListAsync();

            return View(patients);
        }

         

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
