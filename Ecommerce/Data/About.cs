using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Data
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [MaxLength(250)]
        public string? Title { get; set; }
        [MaxLength(1000)]
        public string? Description { get; set; }
        [MaxLength(1000)]
        public string? Content { get; set; }
        public int Status { get; set; }
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
    }
}
