using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Interfaces;

namespace Services.ServiceModels
{
    public class TokenResponseServiceModel : ITokenResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set;}
    }
}
