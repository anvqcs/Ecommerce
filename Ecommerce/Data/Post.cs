using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public int PostCategoryId { get; set; }
        [MaxLength(250)]
        public string? Title { get; set; }
        [MaxLength(250)]
        public string? AliasTitle { get; set; }
        public int Status { get; set; }
        [MaxLength(500)]
        public string? Image { get; set; }
        [MaxLength(1000)]
        public string? Content { get; set; }
        [MaxLength(1000)]
        public string? Description { get; set; }
        [Range(0, int.MaxValue)]
        public int ViewCount { get; set; }
        [MaxLength(1000)]
        public string? MetaKeyword { get; set; }
        [MaxLength(1000)]
        public string? MetaDescription { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        //public PostCategory PostCategory { get; set; } = null!;
        //public ICollection<PostComment> PostComments { get; set; } = new List<PostComment>();
        //public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
    }
}
