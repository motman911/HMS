using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HMS.Data;
using WebApplication1.Models;

namespace HMS.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly App_Db_Contacts _context;

        public DoctorsController(App_Db_Contacts context)
        {
            _context = context;
        }

        // GET: Doctors
        public async Task<IActionResult> Index()
        {
            return View(await _context.Doctors.ToListAsync());
        }

        // GET: Doctors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var doctor = await _context.Doctors.FirstOrDefaultAsync(d => d.id == id);
            if (doctor == null) return NotFound();

            return View(doctor);
        }

        // GET: Doctors/Create
        public IActionResult Create()
        {
            ViewBag.Specialties = new SelectList(GetSpecialties());
            return View();
        }

        // POST: Doctors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,email,phone,specialty")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doctor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Specialties = new SelectList(GetSpecialties(), doctor.specialty);
            return View(doctor);
        }

        // GET: Doctors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null) return NotFound();
            ViewBag.Specialties = new SelectList(GetSpecialties(), doctor.specialty);
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,email,phone,specialty")] Doctor doctor)
        {
            if (id != doctor.id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doctor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(doctor.id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Specialties = new SelectList(GetSpecialties(), doctor.specialty);
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var doctor = await _context.Doctors.FirstOrDefaultAsync(d => d.id == id);
            if (doctor == null) return NotFound();

            return View(doctor);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool DoctorExists(int id)
        {
            return _context.Doctors.Any(e => e.id == id);
        }

        private List<string> GetSpecialties()
        {
            return new List<string>
            {
                "Cardiology",
                "Dermatology",
                "Neurology",
                "Pediatrics",
                "Orthopedics",
                "Gynecology",
                "Psychiatry",
                "Oncology",
                "Radiology",
                "General Surgery"
            };
        }
    }
}
