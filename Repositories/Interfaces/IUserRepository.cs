using Models.EntityModels.Users;
using Shared.Interfaces;

namespace Repository
{
    public interface IUserRepository
    {
        Task<IUser?> GetByIdAsync(long id);
        Task CreateUserAsync(User user);
        Task<IUser?> GetByEmailAsync(string email);
    }
}
