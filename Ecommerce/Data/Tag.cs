using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Data
{
    public class Tag
    {
        [Key]
        [MaxLength(250)]
        public required string TagId { get; set; }
        [MaxLength(250)]
        public string? Title { get; set; }
        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
