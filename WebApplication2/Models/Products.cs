using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Products
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool Status { get; set; }
            public string MainImg { get; set; }
            public decimal Price { get; set; }
            public decimal Discount { get; set; }
            public int Quantity { get; set; }
            public int Rate { get; set; }

            public int CategoryId { get; set; }

            [ForeignKey(nameof(CategoryId))]
            public Categories Category { get; set; }

            public int BrandId { get; set; }

            [ForeignKey(nameof(BrandId))]
            public Brands Brand { get; set; }
        }

    }

