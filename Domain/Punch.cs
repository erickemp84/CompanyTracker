using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class Punch
    {
        public Guid Id {get; set;}

        public string ClockIn {get; set;}

        public string ClockOut {get; set;}

        public string ClockInLongLat {get; set;}

        public string ClockOutLongLat {get; set;}

        public ICollection<Billables> Billables {get; set;}

        public ICollection<AppUser> AppUser {get; set;}

        public ICollection<Job> Job {get; set;}
    }
}