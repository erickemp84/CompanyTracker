using System;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class Job
    {
        public Guid Id {get; set;}

        public string Name {get; set;}

        public string Location {get; set;}

        public string Customer {get; set;}
        
    }
}