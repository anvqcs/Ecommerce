using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data
{
    public class FeedBack
    {
        [Key]
        public int FeedBackId { get; set; }
        [MaxLength(250)]
        public string? Name { get; set; }
        [MaxLength(250)]
        public string? Email { get; set; }
        [MaxLength(50)]
        public string? PhoneNumber { get; set; }
        [MaxLength(250)]
        public string? Address { get; set; }
        [MaxLength(1000)]
        public string? Content { get; set; }
         
    }
}
