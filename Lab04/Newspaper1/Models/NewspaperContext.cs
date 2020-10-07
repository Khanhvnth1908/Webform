using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Newspaper1.Models
{
    public class NewspaperContext : DbContext
    {
        public NewspaperContext() { 
        }

        public NewspaperContext(DbContextOptions<NewspaperContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Newspaper;user id=test;password=test;Trusted_Connection=True;"); 
            }
        }
    }
}
