﻿namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public DateTime Expiration { get; set; }
        public string? Token { get; set; }
    }
}