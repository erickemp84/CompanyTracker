using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain
{

    public class AppUserCrews
    {
        public Guid AppUserId {get; set;}
        public AppUser AppUser {get; set;}

        public Guid CrewsId {get; set;}
        public Crews Crews {get; set;}
    }

}