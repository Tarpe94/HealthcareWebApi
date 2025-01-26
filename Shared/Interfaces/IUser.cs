namespace Shared.Interfaces
{
    public interface IUser
    {
        public string Username { get; }
        public string Password { get; }
        public string Email { get; }
        public string Phone { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime? Bhirtday { get; }
    }
}
