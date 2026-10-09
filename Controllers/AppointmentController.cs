using HospitalSystem.Data;
using HospitalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalSystem.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var appointments = _context.Appointment
                .Include(a => a.Doctor)
                .ThenInclude(d => d.Specialization)
                .ToList();

            return View(appointments);
        }

        [HttpGet]
        public IActionResult Create(int doctorId)
        {
            var doctor = _context.Doctor
                .Include(d => d.Specialization)
                .FirstOrDefault(d => d.DoctorId == doctorId);

            if (doctor == null)
            {
                return NotFound();
            }

            ViewBag.Doctor = doctor;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Appointment.Add(appointment);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            var doctor = _context.Doctor
                .Include(d => d.Specialization)
                .FirstOrDefault(d => d.DoctorId == appointment.DoctorId);

            ViewBag.Doctor = doctor;

            return View(appointment);
        }
    }
}