using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data
{
    public class Slider
    {
        [Key]
        public int SliderId { get; set; }
        [MaxLength(250)]
        public string? Title { get; set; }
        [MaxLength(500)]
        public string? Image { get; set; }
        public int Sort {  get; set; }
        [MaxLength(250)]
        public string? Link { get; set; }
        public int Status { get; set; }
    }
}
