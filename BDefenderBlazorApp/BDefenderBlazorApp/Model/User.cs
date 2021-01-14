using System.ComponentModel.DataAnnotations;

namespace BDefenderBlazorApp.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Username must be at least 4 characters.")]
        [MaxLength(20, ErrorMessage = "Username may have a maximum of 20 characters.")]
        public string Username { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [Phone]
        [MinLength(8, ErrorMessage = "Phone number must be at least of 10 digits.")]
        [MaxLength(17, ErrorMessage = "Phone number may have a maximum of 17 digits.")]
        public string PhoneNumber { get; set; }
        [Required]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        [MaxLength(18, ErrorMessage = "Password may have a maximum of 18 characters.")]
        public string Password { get; set; }
        [Required]
        public string Affiliation { get; set; }
    }
}
