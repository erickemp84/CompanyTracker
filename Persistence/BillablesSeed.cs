using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class BillablesSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Billables.Any()) return;
            
            var billables = new List<Billables>
            {
                new Billables {
                    Name = "Bob"
                },
                new Billables {
                    Name = "Steven"
                },
                new Billables {
                    Name = "Kristi"
                },
                new Billables {
                    Name = "Lorene"
                }
            };

            await context.Billables.AddRangeAsync(billables);
            await context.SaveChangesAsync();
        }
    }
}