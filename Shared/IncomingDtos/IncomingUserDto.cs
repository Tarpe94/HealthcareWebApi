using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.IncomingDtos
{
    public record IncomingUserDto
    {
            public string Username { get; init; }
            public string Password { get; init; }
            public string Email { get; init; }
            public string Phone { get; init; }
            public string FirstName { get; init; }
            public string LastName { get; init; }
            public DateTime? Bhirtday { get; init; }
        }
    }
