using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CDSMovie.Models;

namespace CDSMovie.Controllers
{
    public class MovieController : ApiController
    {
        Movie[] movies = new Movie[] {
            new Movie { ImdbID = "tt1", Name = "The Movie With a Name", Category = "Good Movie Genere" },
            new Movie { ImdbID = "tt2", Name = "Cant Belive This is a Movie", Category = "Shit Movie Genere" },
            new Movie { ImdbID = "tt3", Name = "The One We Lost", Category = "Kinda Good Movie Genere" }
        };
        // /api/movie
        public IEnumerable<Movie> GetAllMovies()
        {
            return movies;
        }

        // /api/movie/{id}
        public IHttpActionResult GetProduct(int imdbID)
        {
            var movie = movies.FirstOrDefault((p) => p.ImdbID.Equals(imdbID));
            if ( movie == null )
            {
                return NotFound();
            }
            return Ok(movie);
        }
    }
}
