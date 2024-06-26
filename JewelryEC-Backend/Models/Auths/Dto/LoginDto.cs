using System.ComponentModel.DataAnnotations;

namespace JewelryEC_Backend.Models.Auths.Dto
{
    public class LoginDto
    {
        [Required(ErrorMessage = "{0} is required.")]
        [EmailAddress(ErrorMessage = "{0} is not in correct format.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} is required.")]
        public string Password { get; set; }

    }
}
