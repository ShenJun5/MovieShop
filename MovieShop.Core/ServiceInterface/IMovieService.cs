using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Core.Entities;
using MovieShop.Core.Models.Response;

namespace MovieShop.Core.ServiceInterface
{
    public interface IMovieService
    {
        Task<MovieDetailsResponseModel> GetMovieById(int id);

        //IEnumerable<Movie> GetTop25GrossingMovies();
        Task<IEnumerable<MovieCardResponseModel>> GetTop25GrossingMovies();
    }
}
