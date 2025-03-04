﻿namespace BurberDinner.Application.Services.Authentication
{
    public record AuthenticationResult 
    {
        public Guid GuidId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}