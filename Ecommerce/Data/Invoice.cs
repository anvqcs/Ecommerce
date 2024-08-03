using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public int Status { get; set; }
        public int SupplierId { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public int DeleteBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DeleteDate { get; set; }
        public Supplier Supplier { get; set; } = null!;
        public InvoiceDetail? InvoiceDetail { get; set; }
    }
}
