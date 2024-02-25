﻿using Microsoft.AspNetCore.Identity;

namespace BookApi.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Custom { get; set; }
    }
}
