using System;
using System.Collections.Generic;
using System.Text;
using MovieShop.Core.Entities;

namespace MovieShop.Core.RepositoryInterface
{
    public interface IMovieRepository: IAsyncRepository<Movie>
    {
        IEnumerable<Movie> GetTopRevenueMovies();
        IEnumerable<Movie> GetTopRatedMovies();
    }
}
