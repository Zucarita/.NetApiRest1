using System.ComponentModel.DataAnnotations;

namespace ExApiRest.Webapi.DTOs
{
    public class UserLoginRequestDTO
    {
        [Required]
        public string Email { get; set; }

        [Required] public string Password { get;}
    }
}
