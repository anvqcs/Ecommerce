using System.ComponentModel.DataAnnotations;
using static NuGet.Packaging.PackagingConstants;

namespace Ecommerce.Data
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(100)]
        public string? Password { get; set; }
        [MaxLength(250)]
        public string? FullName { get; set; }
        [MaxLength(250)]
        public string? Email { get; set; }
        [MaxLength(50)]
        public string? PhoneNumber { get; set; }
        [MaxLength(250)]
        public string? Address { get; set; }
        [MaxLength(50)]
        public string? Gender { get; set; }
        public DateOnly Birthday { get; set; }
        [MaxLength(500)]
        public string? Image {  get; set; }
        public bool Validity { get; set; }
        public int Role {  get; set; }
        public ICollection<Order> Orders { get; set; } = null!;
    }
}
