using Models.EntityModels.Users;
using Shared.Interfaces;

namespace Repository
{
    public interface IUserRepository
    {
        Task<IUser?> GetById(long id);
        Task CreateUserAsync(User user);
    }
}
