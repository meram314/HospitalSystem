using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    [PrimaryKey(nameof(Img), nameof(ProductId))]
    public class ProductSubImage
    {
        public string Img { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public Products Product { get; set; }
    }
}
