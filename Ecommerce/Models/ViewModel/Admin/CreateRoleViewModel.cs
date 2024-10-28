using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.ViewModel.Admin
{
    public class CreateRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
        public string? Description { get; set; }
    }
}
