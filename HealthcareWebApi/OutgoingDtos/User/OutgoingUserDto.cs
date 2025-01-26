namespace HealthcareWebApi.OutgoingDtos.OutgoingUser
{
    public class OutgoingUserDto
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Bhirtday { get; set; }
    }
}
