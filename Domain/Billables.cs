using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Domain
{
    public class Billables
    {
        public Guid Id {get; set;}

        public string Name {get; set;}

        public ICollection<Punch> Punch {get; set;}
    }
}