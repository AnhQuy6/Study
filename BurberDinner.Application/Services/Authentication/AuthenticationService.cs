using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        {
            var result = new AuthenticationResult();
            result.GuidId = Guid.NewGuid();
            result.FirstName = "firstName";
            result.LastName = "lastName";
            result.Email = email;
            result.Token = "sssss";
            return result;
        }

        

        //public AuthenticationResult Register(string firstName, string lastName, string email, string password)
        //{
        //    return new AuthenticationResult(
        //        Guid.NewGuid,
        //        firstName,
        //        lastName,
        //        email,
        //        "token");
        //}
    }
}
