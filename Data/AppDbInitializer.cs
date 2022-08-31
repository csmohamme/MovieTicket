using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieTicket.Models;
using MovieTicket.Data.Enums;

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
                    context.Actors.AddRange(new List<Actor>(){
                        new Actor(){
                            FullName = "actor 1",
                            Bio = "This is the bio of the first actor",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor(){
                            FullName = "actor 2",
                            Bio = "This is the bio of the first actor",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor(){
                            FullName = "actor 3",
                            Bio = "This is the bio of the first actor",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor(){
                            FullName = "actor 4",
                            Bio = "This is the bio of the first actor",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor(){
                            FullName = "actor 5",
                            Bio = "This is the bio of the first actor",
                            ProfilePictureURL="http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>(){
                        new Producer(){
                            FullName = "Producer 1",
                             Bio = "This is the bio of the first producer",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer(){
                            FullName = "Producer 2",
                             Bio = "This is the bio of the first producer",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer(){
                            FullName = "Producer 3",
                             Bio = "This is the bio of the first producer",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer(){
                            FullName = "Producer 4",
                             Bio = "This is the bio of the first producer",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer(){
                            FullName = "Producer 5",
                             Bio = "This is the bio of the first producer",
                            ProfilePictureURL="http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>(){
                        new Movie(){
                            Name = "Cold Soles",
                            Description = "this is the cold soles movie description",
                            Price = 39.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate =DateTime.Now.AddDays(3) ,
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId =1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie(){
                            Name = "Scoob",
                            Description = "this is the Scoob movie description",
                            Price = 35.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate =DateTime.Now.AddDays(-10) ,
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId =1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie(){
                            Name = "Race",
                            Description = "this is the Race movie description",
                            Price = 39.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate =DateTime.Now.AddDays(-10) ,
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId =1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie(){
                            Name = "Ghost",
                            Description = "this is the Ghost movie description",
                            Price = 39.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate =DateTime.Now ,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId =4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie(){
                            Name = "The Shawshank Redemption",
                            Description = "this is the Shawshank Redemption movie description",
                            Price = 39.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate =DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId =1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie(){
                            Name = "Life",
                            Description = "this is the Life movie description",
                            Price = 39.5,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate =DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId =3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>(){
                       new Actor_Movie(){
                        MovieId = 1,
                        ActorId = 1
                       },
                        new Actor_Movie(){
                        MovieId = 1,
                        ActorId = 3
                       },
                        new Actor_Movie(){
                        MovieId = 2,
                        ActorId = 1
                       },
                        new Actor_Movie(){
                        MovieId =2,
                        ActorId = 4
                       },
                        new Actor_Movie(){
                        MovieId = 3,
                        ActorId = 1
                       },
                        new Actor_Movie(){
                        MovieId = 3,
                        ActorId = 2
                       },
                        new Actor_Movie(){
                        MovieId = 3,
                        ActorId = 5
                       },
                        new Actor_Movie(){
                        MovieId = 4,
                        ActorId = 2
                       },
                        new Actor_Movie(){
                        MovieId = 4,
                        ActorId = 3
                       },
                        new Actor_Movie(){
                        MovieId = 4,
                        ActorId = 4
                       },
                        new Actor_Movie(){
                        MovieId = 5,
                        ActorId = 2
                       },
                        new Actor_Movie(){
                        MovieId = 5,
                        ActorId = 3
                       },
                        new Actor_Movie(){
                        MovieId = 5,
                        ActorId = 4
                       },
                        new Actor_Movie(){
                        MovieId = 5,
                        ActorId = 5
                       },
                        new Actor_Movie(){
                        MovieId = 6,
                        ActorId = 3
                       },
                        new Actor_Movie(){
                        MovieId = 6,
                        ActorId = 4
                       },
                       new Actor_Movie(){
                        MovieId = 6,
                        ActorId = 5
                       }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}