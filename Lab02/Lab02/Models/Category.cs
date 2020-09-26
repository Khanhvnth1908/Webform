using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab02.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]

        public int CategoryID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]

        public string CategoryName { get; set; }
        [Display(Name = "Movie Description")]

        public string Description { get; set; }
        public virtual ICollection<Movie> Movie { get; set; }
    }
}