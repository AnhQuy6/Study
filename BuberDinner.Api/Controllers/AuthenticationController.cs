using BuberDinner.Contracts.Authentication;
using BurberDinner.Application.Services.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request) 
        {
            var authResult = _authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);
            var response = new AuthenticationResponse
            {
                GuidId = authResult.GuidId,
                FirstName = authResult.FirstName,
                LastName = authResult.LastName,
                Email = authResult.Email,
                Token = authResult.Token,
            };
            return Ok(response);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(request.Email, request.Passwsold);
            var response = new AuthenticationResponse
            {
                GuidId = authResult.GuidId,
                FirstName = authResult.FirstName,
                LastName = authResult.LastName,
                Email = authResult.Email,
                Token = authResult.Token,
            };
            return Ok(response);
        }

    }
}
