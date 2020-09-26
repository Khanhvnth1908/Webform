using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab02.Models
{
    public class Movie
    {
        [ScaffoldColumn(false)]

        public int MovieID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]

        public string MovieName { get; set; }
        [Required,StringLength(10000),Display(Name = "Movies Description"),DataType(DataType.MultilineText)]

        public string Description { get; set; }
        public string ImagePath { get; set; }

        [Display(Name ="Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}