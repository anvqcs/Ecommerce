using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(2000)]
        public string? Message { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime ContactDate { get; set; }
    }
}
