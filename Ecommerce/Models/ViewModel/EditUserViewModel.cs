﻿using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.ViewModel
{
    public class EditUserViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        public List<string> Claims { get; set; } = new List<string>();  
        public IList<string> Roles { get; set; } = new List<string>();  
    }
}
