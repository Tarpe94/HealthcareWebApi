namespace Services.Helpers
{
    public class JwtOptions
    {
        public string Audit { get; set; }
        public string Issuer { get; set; }
        public string JwtSecretKey { get; set; }
        public int ExparationAccessTime { get; set; }
        public int ExparationRefreshTime { get; set; }
    }
}
