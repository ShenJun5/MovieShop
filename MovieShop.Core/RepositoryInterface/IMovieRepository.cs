using System;
using System.Collections.Generic;
using System.Text;
using MovieShop.Core.Entities;
using System.Threading.Tasks;

namespace MovieShop.Core.RepositoryInterface
{
    public interface IMovieRepository: IAsyncRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetTopRevenueMovies();
        Task<IEnumerable<Movie>> GetTopRatedMovies();
    }
}
