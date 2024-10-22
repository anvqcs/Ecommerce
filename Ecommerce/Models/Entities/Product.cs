using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [MaxLength(200)]
        public string? Name { get; set; }

        [MaxLength(1000)]
        public string? Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        public int ProductCategoryId { get; set; } // Foreign key
        public ProductCategory ProductCategory { get; set; } = null!;

        [Column(TypeName = "DateTime")]
        public DateTime CreatedDate { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
