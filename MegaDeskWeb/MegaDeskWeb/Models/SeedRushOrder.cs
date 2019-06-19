using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MegaDeskWeb.Models
{
    public class SeedRushOrder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskWebContext>>()))
            {
                // Look for any movies.
                if (context.RushOrder.Any())
                {
                    return;   // DB has been seeded
                }
                context.RushOrder.AddRange(
                    new RushOrder
                    {
                        RushOrderType = "No Rush",
                        RushOrderPrice = 0
                    },
                    new RushOrder
                    {
                        RushOrderType = "No Rush",
                        RushOrderPrice = 0

                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
