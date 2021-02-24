﻿using MovieShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MovieShop.Core.RepositoryInterface;
using System.Threading.Tasks;
using MovieShop.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MovieShop.Infrastructure.Repositories
{
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _dbContext.Users.Include(u => u.Roles).FirstOrDefaultAsync(u => u.Email == email);
            return user;
        }
    }
}
