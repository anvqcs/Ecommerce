using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Entities
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }
        [MaxLength(1000)]
        public string? Description { get; set; }
        public int Status { get; set; }

        public int Sort { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime CreatedDate { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
