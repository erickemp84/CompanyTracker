using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class AppUserSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.AppUsers.Any()) return;
            
            var appusers = new List<AppUser>
            {
                new AppUser
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "johndoe@email.com"
                },
                new AppUser {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Email = "janedoe@email.com"
                },
                new AppUser {
                    FirstName = "Chris",
                    LastName = "Christopher",
                    Email = "chrischristopher@email.com"
                },
                new AppUser {
                    FirstName = "Ashleigh",
                    LastName = "Ashley",
                    Email = "ashleighashley@email.com"
                }
            };

            await context.AppUsers.AddRangeAsync(appusers);
            await context.SaveChangesAsync();
        }
    }
}