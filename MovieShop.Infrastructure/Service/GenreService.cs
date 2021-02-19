using MovieShop.Core.Entities;
using MovieShop.Core.RepositoryInterface;
using MovieShop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Infrastructure.Service
{
    public class GenreService : IGenreService
    {
        private readonly IAsyncRepository<Genre> _genreRepository;
        public GenreService(IAsyncRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public IEnumerable<Genre> GetAllGenres()
        {
            var genres = _genreRepository.ListAllAsync();
            return genres;
        }
    }
}
