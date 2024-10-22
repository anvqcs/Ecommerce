using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Entities.Identity
{
    public class Role : IdentityRole
    {
        [MaxLength(1000)]
        public string? Description { get; set; }
    }
}
