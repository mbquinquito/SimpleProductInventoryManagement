using System.ComponentModel.DataAnnotations;

namespace SimpleProductInventoryManagement.PLEASE.Models.Authentication
{
    public class AuthRequestVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }

}
