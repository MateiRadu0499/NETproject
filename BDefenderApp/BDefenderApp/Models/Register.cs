using System.ComponentModel.DataAnnotations;

namespace BDefenderApp.Models
{
    public class Register
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "PhoneNumber")]
        public int PhoneNumber { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password required")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name = "Affiliation")]
        public string Affiliation { get; set; }
    }
}
