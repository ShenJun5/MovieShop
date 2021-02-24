using MovieShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Core.RepositoryInterface
{
    public interface IUserRepository:IAsyncRepository<User>
    {
        Task<User> GetUserByEmail(String email);
    }
}
