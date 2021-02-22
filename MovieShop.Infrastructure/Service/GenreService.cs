using MovieShop.Core.Entities;
using MovieShop.Core.RepositoryInterface;
using MovieShop.Core.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Infrastructure.Service
{
    public class GenreService : IGenreService
    {
        private readonly IAsyncRepository<Genre> _genreRepository;
        public GenreService(IAsyncRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
            var genres = await _genreRepository.ListAllAsync();
            return genres;
        }
    }
}
