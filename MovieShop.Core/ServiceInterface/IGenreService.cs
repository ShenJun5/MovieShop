using MovieShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Core.ServiceInterface
{
    public interface IGenreService
    {
        IEnumerable<Genre> GetAllGenres();
    }
}
