using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class CustomerSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Customers.Any()) return;
            
            var Customers = new List<Customer>
            {
                new Customer {
                    Name = "Stephanie"
                },
                new Customer {
                    Name = "Brandon"
                },
                new Customer {
                    Name = "Laura"
                },
                new Customer {
                    Name = "Lisa"
                },
                new Customer {
                    Name = "Brian"
                },
            };

            await context.Customers.AddRangeAsync(Customers);
            await context.SaveChangesAsync();
        }
    }
}