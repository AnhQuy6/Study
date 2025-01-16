using BurberDinner.Application.Common.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator )
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }
        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            // 1. Kiểm tra nếu user đã tồn tại
            // 2. Tạo user
            // 3. Tạo JWT token

            Guid userId = Guid.NewGuid();

            var token = _jwtTokenGenerator.GenerateJwt(userId, firstName, lastName);
            var result = new AuthenticationResult
            {
                GuidId = userId,
                FirstName = "firstName",
                LastName = "lastName",
                Email = email,
                Token = token,
            };
            return result;
        }



        public AuthenticationResult Login(string email, string password)
        {
            var rusult = new AuthenticationResult 
            {
                GuidId = Guid.NewGuid(),
                FirstName = "firstName",
                LastName = "lastName",
                Email = email,
                Token = "sssss",
            };
            return rusult;
        }
    }
}
