using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class Crews
    {
        public Guid Id {get; set;}

        public string Name {get; set;}

        public List<AppUserCrews> AppUserCrews {get; set;}

    }
}