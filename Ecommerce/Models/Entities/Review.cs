using Ecommerce.Models.Entities.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public string? UserId { get; set; }
        public User User { get; set; } = null!;

        [Range(1, 5)]
        public int Rating { get; set; }

        [MaxLength(2000)]
        public string? Comment { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime ReviewDate { get; set; }
    }
}
