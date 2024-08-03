using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        [MaxLength(250)]
        public string? Title { get; set; }
        [MaxLength(1000)]
        public string? Description { get; set; }
        [MaxLength(250)]
        public string? Url { get; set; }
        [MaxLength(1000)]
        public string? Target { get; set; }
        public int Status { get; set; }
        public int Position { get; set; }
    }
}
