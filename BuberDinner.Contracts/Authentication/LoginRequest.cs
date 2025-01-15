﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Contracts.Authentication
{
    public record LoginRequest
    {
        public string Email { get; init; }
        public string Passwsold { get; set; }
    }
}
