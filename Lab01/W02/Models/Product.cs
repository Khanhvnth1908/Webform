using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace W02.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ProductName { get; set; }


        [Required, StringLength(10000), Display(Name = "Product Description"),
            DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UntiPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }

    }

    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Product Desciption")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    public class ProductContext : DbContext
    {
        public ProductContext() : base("W02")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }

    public class ProductDatabaseInitializer :
        DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Cars"
                },
                  new Category
                {
                    CategoryID = 2,
                    CategoryName = "Planes"
                },
                    new Category
                {
                    CategoryID = 3,
                    CategoryName = "Trucks"
                },
                      new Category
                {
                    CategoryID = 4,
                    CategoryName = "Boats"
                },
                        new Category
                {
                    CategoryID = 5,
                    CategoryName = "Rockets"
                },

            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Convertible Car",
                    Description = "Et ipsum ad diam et consetetur nibh consetetur duo ea." + "Tutte di grazia pregator etterno!",
                    ImagePath = "carconvert.png",
                    UntiPrice = 22.05,
                    CategoryID = 1
                },
                 new Product
                {
                    ProductID = 2,
                    ProductName = "Convertible Car",
                    Description = "Et ipsum ad diam et consetetur nibh consetetur duo ea." + "Tutte di grazia pregator etterno!",
                    ImagePath = "carconvert.png",
                    UntiPrice = 22.05,
                    CategoryID = 1
                },
                  new Product
                {
                    ProductID = 3,
                    ProductName = "Convertible Car",
                    Description = "Et ipsum ad diam et consetetur nibh consetetur duo ea." + "Tutte di grazia pregator etterno!",
                    ImagePath = "carconvert.png",
                    UntiPrice = 22.05,
                    CategoryID = 1
                },
                   new Product
                {
                    ProductID = 4,
                    ProductName = "Convertible Car",
                    Description = "Et ipsum ad diam et consetetur nibh consetetur duo ea." + "Tutte di grazia pregator etterno!",
                    ImagePath = "carconvert.png",
                    UntiPrice = 22.05,
                    CategoryID = 1
                },
                    new Product
                {
                    ProductID = 5,
                    ProductName = "Convertible Car",
                    Description = "Et ipsum ad diam et consetetur nibh consetetur duo ea." + "Tutte di grazia pregator etterno!",
                    ImagePath = "carconvert.png",
                    UntiPrice = 22.05,
                    CategoryID = 1
                },
                       new Product
                {
                    ProductID = 6,
                    ProductName = "Convertible Car",
                    Description = "Et ipsum ad diam et consetetur nibh consetetur duo ea." + "Tutte di grazia pregator etterno!",
                    ImagePath = "carconvert.png",
                    UntiPrice = 22.05,
                    CategoryID = 2
                },
                       new Product
                {
                    ProductID = 7,
                    ProductName = "Glider",
                    Description = "This fun glider is made from real balsa wood. Some assembly required.",
                    ImagePath="planeglider.png",
                    UntiPrice = 4.95,
                    CategoryID = 2
                },
                        new Product
                {
                    ProductID = 8,
                    ProductName = "Paper Plane",
                    Description = "This paper plane is like no other paper plane. Some folding required.",
                    ImagePath="planepaper.png",
                    UntiPrice = 2.95,
                    CategoryID = 2
                },
                        new Product
                {
                    ProductID = 9,
                    ProductName = "Propeller Plane",
                    Description = "Rubber band powered plane features two wheels.",
                    ImagePath="planeprop.png",
                    UntiPrice = 32.95,
                    CategoryID = 2
                 },
                        new Product
                 {
                    ProductID = 10,
                    ProductName = "Early Truck",
                    Description = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                    ImagePath="truckearly.png",
                    UntiPrice = 15.00,
                    CategoryID = 3
                  },
                        new Product
                  {
                            ProductID = 11,
                            ProductName = "Fire Truck",
                            Description = "You will have endless fun with this one quarter sized fire truck.",
                            ImagePath="truckfire.png",
                            UntiPrice = 26.00,
                            CategoryID = 3
                    },
                        new Product
                        {
                        ProductID = 12,
                        ProductName = "Big Truck",
                        Description = "This fun toy truck can be used to tow other trucks that are not as big.",
                        ImagePath="truckbig.png",
                        UntiPrice = 29.00,
                        CategoryID = 3
                        },
                        new Product
                        {
                        ProductID = 13,
                        ProductName = "Big Ship",
                        Description = "Is it a boat or a ship. Let this floating vehicle decide by using its " +
                        "artifically intelligent computer brain!",
                        ImagePath = "boatbig.png",
                        UntiPrice = 95.00,
                        CategoryID = 4
                        },
                        new Product
                        {
                        ProductID = 14,
                        ProductName = "Paper Boat",
                        Description = "Floating fun for all! This toy boat can be assembled in seconds.Floats for minutes!" +
                        "Some folding required.",
                        ImagePath="boatpaper.png",
                        UntiPrice = 4.95,
                        CategoryID = 4
                        },
                        new Product
                        {
                        ProductID = 15,
                        ProductName = "Sail Boat",
                        Description = "Put this fun toy sail boat in the water and let it go!",
                        ImagePath="boatsail.png",
                        UntiPrice = 42.95,
                        CategoryID = 4
                        },
                        new Product
                        {
                            ProductID = 16,
                            ProductName = "Rocket",
                            Description = "This fun rocket will travel up to a height of 200 feet.",
                        ImagePath = "rocket.png",
                            UntiPrice = 122.95,
                            CategoryID = 5
                        }

            };
            return products;
        }
    }
}