﻿using Microsoft.AspNetCore.Identity;

namespace BlazorAuthWithIdentityAndJWT.Server.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
