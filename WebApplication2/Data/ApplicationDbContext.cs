

    using Microsoft.EntityFrameworkCore;
    using WebApplication2.Models;
    using static WebApplication2.Models.ProductColour;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : DbContext
        {
            public DbSet<Categories> Categories { get; set; }
            public DbSet<Brands> Brands { get; set; }
            public DbSet<Products> Products { get; set; }
            public DbSet<ProductSubImage> ProductSubImages { get; set; }
            public DbSet<ProductColor> ProductColors { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlServer("Data Source=.;initial catalog = Ecommerce535;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
            }
        }
    }
