using System.ComponentModel.DataAnnotations;

namespace FirstGroup_1.Models.ViewModels
{
    public class LoginViewModel
    { 
        [Required]
        [StringLength(100)]
        public string Username { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        public string Password { get; set; } = string.Empty;

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; } = false;


    }
}
