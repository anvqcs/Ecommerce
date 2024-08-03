using System.ComponentModel.DataAnnotations;
using static NuGet.Packaging.PackagingConstants;

namespace Ecommerce.Data
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        [Range(0, double.MaxValue)]
        public double UnitPrice { get; set; }
        //public Order Order { get; set; } = null!;
        //public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
