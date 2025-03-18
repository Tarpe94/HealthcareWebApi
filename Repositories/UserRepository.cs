using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Models.Context;
using Models.EntityModels.Users;
using Shared.Interfaces;

namespace Repository
{
    public class UserRepository(EntityContext _context, IMapper _mapper) : IUserRepository
    {
        public async Task<IUser?> GetByIdAsync(long id)
        {
            var user = await _context.FindAsync<User>(id);
            return user;


        }
        public async Task CreateUserAsync(User user)
        {
            await _context.AddAsync(user);
            _context.SaveChanges();
        }

        public async Task<IUser?> GetByEmailAsync(string email)
        {
            var user = await _context.Users
                .Include(x => x.UserRoles)
                .FirstOrDefaultAsync(u => u.Email == email);
            return user;
        }
    }
}
