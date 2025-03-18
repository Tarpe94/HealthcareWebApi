using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces
{
    public interface ITokenResponse
    {
        string AccessToken { get; }
        string RefreshToken { get; }
    }
}
