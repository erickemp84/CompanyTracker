using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class AppUser : IdentityUser
    {
        public Guid Id {get; set;}

        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string Email {get; set;}

        public ICollection<AppUserCrews> Crews {get; set;}
    }
}