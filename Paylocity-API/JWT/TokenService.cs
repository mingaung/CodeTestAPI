using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paylocity_API.JWT
{
    public class TokenService : ITokenService
    {
        IConfiguration _config;
        public TokenService(IConfiguration config) {
            _config = config;
        }
        public string BuildToken(string audience)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"], 
                                            audience, 
                                            null, 
                                            expires: DateTime.Now.AddMinutes(120), 
                                            signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
