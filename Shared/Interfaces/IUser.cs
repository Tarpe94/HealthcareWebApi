using System.Security;

namespace Shared.Interfaces
{
    public interface IUser
    {
        public long Id { get; }    
        public string Username { get; }
        public string Password { get; }
        public string Email { get; }
        public string Phone { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime? Bhirtday { get; }
        public List<IUserRole> UserRoles { get; }
    }
}
