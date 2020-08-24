using System.ComponentModel.DataAnnotations;

namespace QuoraApp.ViewModels
{
    public class EditUserPasswordViewModel
    {
        public int UserID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
