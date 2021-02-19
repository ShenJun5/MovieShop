using System;
using System.Collections.Generic;
using System.Text;
using MovieShop.Core.Entities;
using MovieShop.Core.Models.Response;

namespace MovieShop.Core.ServiceInterface
{
    public interface IMovieService
    {
        Movie GetMovieById(int id);

        //IEnumerable<Movie> GetTop25GrossingMovies();
        IEnumerable<MovieCardResponseModel> GetTop25GrossingMovies();
    }
}
