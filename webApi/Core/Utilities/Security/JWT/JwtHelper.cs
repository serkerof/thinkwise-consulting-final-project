using Core.Extensions;
using Core.Utilities.Security.Encryption;
using Microsoft.Azure.Documents;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol.Plugins;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;

namespace Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        private DateTime _accessTokenExpiration;
        private readonly TokenOptions _tokenOptions;

        public JwtHelper(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }

        private Microsoft.Extensions.Configuration.IConfiguration Configuration { get; }

        private JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims: operationClaims),
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        AccessToken ITokenHelper.CreateToken(User user, List<OperationClaim> operationClaims)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey ?? "12345678901234567890123456789012");
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };
        }

        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddNameIdentifier(JwtRegisteredClaimNames.Email);
            claims.AddNameIdentifier(JwtRegisteredClaimNames.Name);
            claims.AddNameIdentifier(JwtRegisteredClaimNames.UniqueName);
            claims.AddRoles(operationClaims.Select(c => c.ToString()).ToArray());
            return claims;
        }
    }
}