using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieTicket.Models;

namespace MovieTicket.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serivceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serivceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                                Name = "cinema 1",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                                Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                                Name = "cinema 2",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                                Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                                Name = "cinema 3",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                                Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                                Name = "cinema 4",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                                Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                                Name = "cinema 5",
                                Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                                Description = "This is the description of the first cinema"
                        }
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {

                }
                //Movies
                if (!context.Movies.Any())
                {

                }
                //Producers
                if (!context.Producers.Any())
                {

                }
                //Actors & Movies
                if (!context.Actor_Movies.Any())
                {

                }
            }
        }
    }
}