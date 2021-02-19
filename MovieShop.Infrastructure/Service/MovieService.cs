using System;
using System.Collections.Generic;
using System.Text;
using MovieShop.Core.Entities;
using MovieShop.Core.ServiceInterface;
using MovieShop.Core.RepositoryInterface;
using MovieShop.Core.Models.Response;
using MovieShop.Infrastructure.Service;

namespace MovieShop.Infrastructure.Service
{
    
    public class MovieService : IMovieService   
    { 
        private readonly IMovieRepository _movieRepository;
        //Dependency Injection by constructor injection; why readonly: only change in declaration(inside constructor)
        //MovieService movieservice = new MovieService (); will not compile because we have a parameter(a class that implement IMovieRepository)
        //MovieService movieservice = new MovieService (new MovieRepository()); will compile becuase MovieRepository implements IMovieRepository

        public MovieService(IMovieRepository movieRepository) // Constructor with an Interface as parameter: pass a class that implement this Interface
        {
            _movieRepository = movieRepository;
        }
        
        public Movie GetMovieById(int id)
        {
            var movie = _movieRepository.GetByIdAsync(id);
            return movie;
        }

        public IEnumerable<MovieCardResponseModel> GetTop25GrossingMovies()
        {
            var movies = _movieRepository.GetTopRevenueMovies();
            var movieCardResponseModel = new List<MovieCardResponseModel>();
            foreach (var movie in movies)
            {
                var movieCard = new MovieCardResponseModel
                {
                    Id = movie.Id,
                    PosterUrl = movie.PosterUrl,
                    Revenue = movie.Revenue,
                    Title = movie.Title
                };
                movieCardResponseModel.Add(movieCard);
            }
            return movieCardResponseModel;
        }
    }
    
}
