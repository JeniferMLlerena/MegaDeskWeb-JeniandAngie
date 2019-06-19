using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MegaDeskWeb.Models
{
    public class SeedMaterial
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskWebContext>>()))
            {
                // Look for any movies.
                if (context.Material.Any())
                {
                    return;   // DB has been seeded
                }
                context.Material.AddRange(
                    new Material
                    {
                        MaterialType = "Oak",
                        MaterialPrice = 200
                    },
                    new Material
                    {
                        MaterialType = "Laminate",
                        MaterialPrice = 100
                    },
                    new Material
                    {
                        MaterialType = "Pine",
                        MaterialPrice = 50
                    },
                    new Material
                    {
                        MaterialType = "Rose Wood",
                        MaterialPrice = 300
                    },
                    new Material
                    {
                        MaterialType = "Veneer",
                        MaterialPrice = 125
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
