using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class PunchSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Punches.Any()) return;
            
            var punches = new List<Punch>
            {
                new Punch {
                    ClockIn = "8:30",
                    ClockOut = "4:30",
                    ClockInLongLat = "Edmond",
                    ClockOutLongLat = "Edmond"
                }
            };

            await context.Punches.AddRangeAsync(punches);
            await context.SaveChangesAsync();
        }
    }
}


// DateTime ClockIn = new DateTime(2021, 09, 28, 10, 47, 33),
// DateTime ClockOut = new DateTime(2021, 09, 28, 3, 33, 21),
// ClockInLongLat = GeoCoordinate(-97.516426, 35.467560),
// ClockOutLongLat = GeoCoordinate(-97.516426, 35.467560)