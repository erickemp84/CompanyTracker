using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain
{

    public class AppUserCrews
    {
        public int Id {get; set;}

        public int AppUserId {get; set;}
        public AppUser AppUser {get; set;}

        public int CrewsId {get; set;}
        public Crews Crews {get; set;}
    }

}