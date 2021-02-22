using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Entities;
using MovieShop.Core.RepositoryInterface;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repositories
{
    public class MovieRepository : EfRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<IEnumerable<Movie>> GetTopRatedMovies()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetTopRevenueMovies()
        {
            return await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(25).ToListAsync();
        }

        public override async Task<Movie> GetByIdAsync(int id)
        {
            return await _dbContext.Movies.Include(m => m.MovieCasts).ThenInclude(m => m.Cast).Include(m => m.Genres).FirstOrDefaultAsync(m => m.Id == id);
        }
    }
    
}
