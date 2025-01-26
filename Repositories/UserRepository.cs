using AutoMapper;
using Models.Context;
using Models.EntityModels.Users;
using Shared.Interfaces;

namespace Repository
{
    public class UserRepository(EntityContext _context, IMapper _mapper) : IUserRepository
    {
        public async Task<IUser?> GetById(long id)
        {
            var user = await _context.FindAsync<User>(id);
            return user;


        }
        public async Task CreateUserAsync(User user)
        {
            await _context.AddAsync(user);
            _context.SaveChanges();
        }


    }
}
