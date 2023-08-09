using System.ComponentModel.DataAnnotations;

namespace BlazerApp1.Models.User
{
    public class LoginUserDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}