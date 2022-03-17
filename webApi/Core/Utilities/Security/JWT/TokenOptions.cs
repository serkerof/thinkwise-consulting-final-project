namespace Core.Utilities.Security.JWT
{
    public class TokenOptions
    {
        public int AccessTokenExpiration { get; set; }
        public string? Audience { get; set; }
        public string? Issuer { get; set; }
        public string? SecurityKey { get; set; }
    }
}