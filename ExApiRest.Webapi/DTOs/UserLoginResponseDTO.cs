using System.Collections.Generic;

namespace ExApiRest.Webapi.DTOs
{
    public class UserLoginResponseDTO
    {
        public string Token { get; set; }

        public bool Login { get; set; }

        public List<string> Errors { get; set; }
    }
}
