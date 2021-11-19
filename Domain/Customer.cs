using System;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class Customer
    {
        public Guid Id {get; set;}

        public string Name {get; set;}
        
    }
}