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
    public partial class MovieDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Movie> GetMovie([QueryString("MovieID")] int? movieId)
        {
            var _db = new Lab02.Models.MovieContext();
            IQueryable<Movie> query = _db.Movies;
            if (movieId.HasValue && movieId > 0)
            {
                query = query.Where(p => p.MovieID == movieId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}