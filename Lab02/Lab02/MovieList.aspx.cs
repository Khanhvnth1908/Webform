using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Lab02.Models;
using System.Web.ModelBinding;

namespace Lab02
{
    public partial class MovieList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Movie> GetMovies([QueryString("id")] int? categoryId)
        {
            var _db = new Lab02.Models.MovieContext();
            IQueryable<Movie> query = _db.Movies;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.CategoryID == categoryId);
            }
            return query;
        }
    }
}