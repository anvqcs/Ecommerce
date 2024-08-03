using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data
{
    public class PostComment
    {
        [Key]
        public int PostCommentId { get; set; }
        public int PostId { get; set; }
        [MaxLength(250)]
        public string? Name { get; set; }
        [MaxLength(250)]
        public string? Email { get; set; }
        [MaxLength(1000)]
        public string? Content { get; set; }
        public int Status { get; set; }
        public int CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; }
        public Post Post { get; set; } = null!;
    }
}
