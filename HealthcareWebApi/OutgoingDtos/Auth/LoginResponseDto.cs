using System.ComponentModel.DataAnnotations;
using Shared.Interfaces;

namespace HealthcareWebApi.OutgoingDtos.Auth
{
    public class LoginResponseDto: ITokenResponse
    {
        [Required]
        public string AccessToken { get; set; }
        [Required]
        public string RefreshToken { get; set; }

    }
}
