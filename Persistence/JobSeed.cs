using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class JobSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Jobs.Any()) return;
            
            var job = new List<Job>
            {
                new Job {
                    Name = "Doing Something Hard",
                    Location = "Edmond",
                    Customer = "Brian"
                },
                new Job {
                    Name = "Doing something not hard",
                    Location = "Edmond",
                    Customer = "Lisa"
                },
                new Job {
                    Name = "Doing something a little hard.",
                    Location = "Yukon",
                    Customer = "Brandon"
                }, 
                new Job {
                    Name = "Doing something not hard",
                    Location = "Midwest City",
                    Customer = "Laura"
                }
            };

            await context.Jobs.AddRangeAsync(job);
            await context.SaveChangesAsync();
        }
    }
}