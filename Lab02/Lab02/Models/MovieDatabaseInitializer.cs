using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab02.Models
{
    public class MovieDatabaseInitializer : DropCreateDatabaseAlways<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetMoives().ForEach(p => context.Movies.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Act"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Funny"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Mentality"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Rockets"
                },
            };

            return categories;
        }


        private static List<Movie> GetMoives()
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    MovieID = 1,
                    MovieName = "Convertible Car",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included). Power it up and let it go!",
                    ImagePath="imposable.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
                },
                new Movie
                {
                    MovieID = 2,
                    MovieName = "Old-time Car",
                    Description = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    ImagePath="act1.png",
                    UnitPrice = 15.95,
                    CategoryID = 1
                },
                new Movie
                {
                    MovieID = 3,
                    MovieName = "Fast Car",
                    Description = "Yes this car is fast, but it also floats in water.",
                    ImagePath="act2.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Movie
                {
                    MovieID = 4,
                    MovieName = "Super Fast Car",
                    Description = "Use this super fast car to entertain guests.Lights and doors work!",
                    ImagePath="act3.png",
                    UnitPrice = 8.95,
                    CategoryID = 1
                },
                new Movie
                {
                    MovieID = 5,
                    MovieName = "Old Style Racer",
                    Description = "This old style racer can fly (with user assistance). Gravity controls flight duration." +
                    "No batteries required.",
                    ImagePath = "act4.png",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Movie
                {
                    MovieID = 6,
                    MovieName = "Ace Plane",
                    Description = "Authentic airplane toy. Features realistic color and details.",
                    ImagePath="funny1.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Movie
                {
                    MovieID = 7,
                    MovieName = "Glider",
                    Description = "This fun glider is made from real balsa wood.Some assembly required.",
                    ImagePath="funny2.png",
                    UnitPrice = 4.95,
                    CategoryID = 2
                },
                new Movie
                {
                    MovieID = 8,
                    MovieName = "Paper Plane",
                    Description = "This paper plane is like no other paper plane.Some folding required.",
                    ImagePath = "funny3.png",
                    UnitPrice = 2.95,
                    CategoryID = 2
                },
                new Movie
                {
                    MovieID = 9,
                    MovieName = "Propeller Plane",
                    Description = "Rubber band powered plane features two wheels.",
                    ImagePath = "funny4.png",
                    UnitPrice = 32.95,
                    CategoryID = 2
                },
                new Movie
                {
                    MovieID = 10,
                    MovieName = "Early Truck",
                    Description = "This toy truck has a real gas powered engine.Requires regular tune ups.",
                    ImagePath = "mentality1.png",
                    UnitPrice = 15.00,
                    CategoryID = 3
                },
                new Movie
                {
                    MovieID = 11,
                    MovieName = "Fire Truck",
                    Description = "You will have endless fun with this one quarter sized fire truck.",
                    ImagePath = "mentality2.png",
                    UnitPrice = 26.00,
                    CategoryID = 3
                },
                new Movie
                {
                    MovieID = 12,
                    MovieName = "Big Truck",
                    Description = "This fun toy truck can be used to tow other trucks that are not as big.",
                    ImagePath = "mentality3.png",
                    UnitPrice = 29.00,
                    CategoryID = 3
                },
                new Movie
                {
                    MovieID = 13,
                    MovieName = "Big Ship",
                    Description = "Is it a boat or a ship. Let this floating vehicle decide by using its artifically intelligent computer brain!",
                    ImagePath = "family1.png",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Movie
                {
                    MovieID = 14,
                    MovieName = "Paper Boat",
                    Description = "Floating fun for all! This toy boat can be assembled in seconds.Floats for minutes! Some folding required.",
                    ImagePath = "family2.png",
                    UnitPrice = 4.95,
                    CategoryID = 4
                },
                new Movie
                {
                    MovieID = 15,
                    MovieName = "Sail Boat",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath = "family3.png",
                    UnitPrice = 42.95,
                    CategoryID = 4
                },
                new Movie
                {
                    MovieID = 16,
                    MovieName = "Rocket",
                    Description = "This fun rocket will travel up to a height of 200 feet.",
                    ImagePath = "mentality4.png",
                    UnitPrice = 122.95,
                    CategoryID = 5
                }
            };
            return movies;
        }
    }
}