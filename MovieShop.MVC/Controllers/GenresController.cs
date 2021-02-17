using Microsoft.AspNetCore.Mvc;
using MovieShop.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.MVC.Controllers
{
    public class GenresController : Controller
    {

        private readonly MovieShopDbContext _dbContext;
        public GenresController(MovieShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var genres = _dbContext.Genres.ToList();
            return View();
        }
    }
}
