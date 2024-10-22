using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Models.Entities.Identity;

namespace Ecommerce.Models.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string? UserId { get; set; }
        public User User { get; set; } = null!;

        [Column(TypeName = "DateTime")]
        public DateTime OrderDate { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
