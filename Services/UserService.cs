using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Models.EntityModels.Users;
using Repository;
using Services.Interfaces;
using Services.ServiceModels;
using Shared.IncomingDtos;
using Shared.Interfaces;

namespace Services
{
    public class UserService(
        IUserRepository _userRepo, 
        IJwtService jwtService,
        IMapper _mapper) : IUserService
    {

        public async Task<IUser> GetById(long id)
        {
            var res = await _userRepo.GetByIdAsync(id);
            return res;
        }
        public async Task CreateUserAsync(IncomingUserDto user)
        {
            var data = _mapper.Map<User>(user);
            await _userRepo.CreateUserAsync(data);

        }

        public async Task<ITokenResponse> LoginUserAsync(string email, string password)
        {
            var user = await _userRepo.GetByEmailAsync(email);
            // validate password

            // generate tokens
            var token = jwtService.GenerateAccessToken(user.Id, user.UserRoles.Select(x => x.RoleId).ToList());
            var refreshToken = jwtService.GenerateRefreshToken(user.Id);

            return new TokenResponseServiceModel()
            {
                AccessToken = token,
                RefreshToken = refreshToken
            };
        }
    }
}
