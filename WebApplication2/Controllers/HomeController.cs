using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.viewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index(FilterProductVm filter)
        {
            var products = _context.Products.AsQueryable();
            products = products.Include(p => p.Category);
            if(filter.Name != null)
            {
                products = products.Where(p => p.Name.Contains(filter.Name));
            }
            if(filter.MinPrice != 0)
            {
                products = products.Where(p => p.Price >= filter.MinPrice);
            }
            if(filter.MaxPrice != 0)
            {
                products = products.Where(p => p.Price <= filter.MaxPrice);
            }
            if(filter.HotDeals)
            {
                products = products.Where(p => p.Discount > 40);
            }   

            ViewBag.Categories = _context.Categories;
            ViewBag.Brands = _context.Brands;
            ViewBag.TotalPages = (int)Math.Ceiling(products.Count() / 8.0);

            products = products.Skip((filter.page - 1) * 8).Take(8);
            return View(products.AsEnumerable());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult welcome() 
        {
           return View();
        }

        public ViewResult PersonalInfo() 
        {
            var PersonInDb = new List<person>
            {
                new person { Id = 1, Name = "John Doe", Salary = 50000 },
                new person { Id = 2, Name = "Jane Smith", Salary = 60000 },
                new person { Id = 3, Name = "Bob Johnson", Salary = 55000 }
            };

            return View( new personVm
            {
                Persons = PersonInDb,
                count =  PersonInDb.Count()
            });

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult Welcome() 
        {
            return View();
        }


    }
}
