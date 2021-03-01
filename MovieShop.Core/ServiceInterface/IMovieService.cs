using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Core.Entities;
using MovieShop.Core.Models.Request;
using MovieShop.Core.Models.Response;

namespace MovieShop.Core.ServiceInterface
{
    public interface IMovieService
    {
        Task<MovieDetailsResponseModel> GetMovieById(int id);

        //IEnumerable<Movie> GetTop25GrossingMovies();
        Task<IEnumerable<MovieCardResponseModel>> GetTop25GrossingMovies();
        Task<IEnumerable<MovieCardResponseModel>> GetMoviesByGenre(int genreId);
        Task<IEnumerable<ReviewResponseModel>> GetReviewsForMovie(int id);
        Task<IEnumerable<MovieRatingResponseModel>> GetTopRatedMovies();
        Task<MovieDetailsResponseModel> CreateMovie(MovieCreateRequest movieCreateRequest);

    }
}
