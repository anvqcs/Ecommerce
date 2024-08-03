using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [MaxLength(250)]
        public string? Name { get; set; }
        [MaxLength(250)]
        public string? Email { get; set; }
        [MaxLength(50)]
        public string? PhoneNumber { get; set; }
        [MaxLength(250)]
        public string? Address { get; set; }
        //public ICollection<Product> Products { get; set; } = new List<Product>();
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
