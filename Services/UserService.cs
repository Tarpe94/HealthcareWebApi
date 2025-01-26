using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Models.EntityModels.Users;
using Repository;
using Services.Interfaces;
using Shared.IncomingDtos;
using Shared.Interfaces;

namespace Services
{
    public class UserService(IUserRepository _userRepo, IMapper _mapper) : IUserService
    {

        public async Task<IUser> GetById(long id)
        {
            var res = await _userRepo.GetById(id);
            return res;
        }
        public async Task CreateUserAsync(IncomingUserDto user)
        {
            var data = _mapper.Map<User>(user);
            await _userRepo.CreateUserAsync(data);

        }

    }
}
