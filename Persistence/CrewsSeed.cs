using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class CrewsSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Crews.Any()) return;
            
            var crews = new List<Crews>
            {
                new Crews {
                    Name = "Crew 1"
                },
                new Crews { 
                    Name = "Crew 2"
                }, 
                new Crews {
                    Name = "Crew 3"
                },
                new Crews {
                    Name = "Crew 4"
                }
            };

            await context.Crews.AddRangeAsync(crews);
            await context.SaveChangesAsync();
        }
    }
}