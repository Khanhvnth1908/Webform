using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Lab02.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("Movies")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}