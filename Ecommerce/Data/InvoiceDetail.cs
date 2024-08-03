using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data
{
    public class InvoiceDetail
    {
        [Key]
        public int InvoiceDetailId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        //public Invoice Invoice { get; set; } = null!;
        //public ICollection<Product> Products { get; set; } = null!;
    }
}
