﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public IEnumerable<Movie> GetTopRatedMovies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetTopRevenueMovies()
        {
            return _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(25);
        }

        public override Movie GetByIdAsync(int id)
        {
            return _dbContext.Movies.Include(m => m.MovieCasts).ThenInclude(m => m.Cast).Include(m => m.Genres).FirstOrDefault(m => m.Id == id);
        }
    }
    
}
