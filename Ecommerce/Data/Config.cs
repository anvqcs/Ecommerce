using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data
{
    public class Config
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public required string Key { get; set; }
        [MaxLength(1000)]
        public string? Value { get; set; }
    }
}
