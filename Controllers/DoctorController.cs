using HospitalSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalSystem.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DoctorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string name, int? specializationId, int page = 1)
        {
            int pageSize = 3;

            var doctors = _context.Doctor
                .Include(d => d.Specialization)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(name))
            {
                doctors = doctors.Where(d => d.Name.Contains(name));
            }

            if (specializationId.HasValue)
            {
                doctors = doctors.Where(
                    d => d.SpecializationId == specializationId.Value);
            }

            int totalDoctors = doctors.Count();

            int totalPages = (int)Math.Ceiling(
                (double)totalDoctors / pageSize);

            var doctorsList = doctors
                .OrderBy(d => d.DoctorId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.Specialization = _context.Specialization.ToList();
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            ViewBag.Name = name;
            ViewBag.SpecializationId = specializationId;

            return View(doctorsList);
        }
    }
}