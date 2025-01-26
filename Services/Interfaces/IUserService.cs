using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.IncomingDtos;
using Shared.Interfaces;

namespace Services.Interfaces
{
    public interface IUserService
    {
        Task<IUser> GetById(long id);
        Task CreateUserAsync(IncomingUserDto user);
    }
}
