using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data
{
    public class Order
    {
        [Key]
        public int OrdersId { get; set; }
        public DateTime OrdersDate { get; set; }
        public int Status { get; set; }
        public bool Delivered { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int CustomerId { get; set; }
        [Range(0, int.MaxValue)]
        public int Discount { get; set; }
        public Customer Customer { get; set; } = null!;
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    }
}
