using System.ComponentModel.DataAnnotations;

namespace BDefenderApp.Models
{
    public class Login
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }
        [Display(Name = "Password")]

        [DataType(DataType.Password)]

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
    }
}
