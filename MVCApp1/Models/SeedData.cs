using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp1.Data;
using System;
using System.Linq;

namespace MVCApp1.Models
{
    public static class SeedData
    { 
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCApp1Context( 
                serviceProvider.GetRequiredService<DbContextOptions<MVCApp1Context>>())) 
            {
                //Look for any movies 
                if (context.Movie.Any())
                {
                    return;//Db has been seeded
                } 
                
                //Añadir un punto de depuración para transcurrir a lo largo del código línea por línea
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally", 
                        RealeseDate = DateTime.Parse("1989-2-12"), 
                        Genre = "Romantic Comedy", 
                        Price = 7.99M, 
                        Raiting = "R"
                    },
                    new Movie
                    {
                        Title = "GhostBusters",
                        RealeseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M, 
                        Raiting = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters2",
                        RealeseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M, 
                        Raiting = "PG-13"   
                    },
                    new Movie
                    {
                        Title = "Río Bravo",
                        RealeseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M, 
                        Raiting = "R"   
                    }
                    ); 

                context.SaveChanges();
            }
        }
    }
}
