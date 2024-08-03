using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [MaxLength(250)]
        public string? Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
