using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public int BrandId { get; set; }
        public int SupplierId { get; set; }
        [MaxLength(250)]
        public string? ProductName { get; set; }
        [MaxLength(250)]
        public string? AliasName { get; set; }
        [MaxLength(1000)]
        public string? Description { get; set; }
        [MaxLength(1000)]
        public string? Content { get; set; }
        public int Status { get; set; }
        [MaxLength(500)]
        public string? Image { get; set; }
        [MaxLength(1000)]
        public string? ListImage { get; set; }
        [Range(0, double.MaxValue)]
        public double? Price { get; set; }
        [Range(0, double.MaxValue)]
        public double? PromotionalPrice { get; set; }
        public bool? VAT { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        [Range(0, 100)]
        public int Warranty { get; set; }
        public DateOnly Hot { get; set; }
        [Range(0, int.MaxValue)]
        public int ViewCount { get; set; }
        [MaxLength(1000)]
        public string? MetaKeyword { get; set; }
        [MaxLength(1000)]
        public string? MetaDescription { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        //public ProductCategory ProductCategory { get; set; } = null!;
        //public Brand Brand { get; set; } = null!;
        ////public Supplier Supplier { get; set; } = null!;
        //public InvoiceDetail InvoiceDetail { get; set; } = null!;
        //public OrderDetail OrderDetail { get; set; } = null!;
        //public ICollection<ProductComment> ProductComments { get; set; } = new List<ProductComment>();
    }
}
