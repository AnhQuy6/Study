using BurberDinner.Application.Common.Interfaces.Authentication;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BurberDinner.Infrastructure.Authentication
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        public string GenerateJwt(Guid userId, string firstName, string lastName)
        {
            // Tạo khóa đối xứng
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));

            // Tạo claims
            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName, firstName),
                new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            // Xác định phương pháp kí
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Tạo token
            var securityToken = new JwtSecurityToken(
            issuer: "BuberDinner",
            claims: claims,
            expires: DateTime.Now.AddDays(10),
            signingCredentials: signingCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(securityToken);

        }
    }
}
