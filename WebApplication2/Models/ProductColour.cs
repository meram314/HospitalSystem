using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class ProductColour
    {
        [PrimaryKey(nameof(Color), nameof(ProductId))]

        public class ProductColor
        {
            public string Color { get; set; }
            public int ProductId { get; set; }
            [ForeignKey(nameof(ProductId))]
            public Products Product { get; set; }
        }
    }
}
