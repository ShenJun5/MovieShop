using MovieShop.Core.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieShop.Core.Models.Response;

namespace MovieShop.Core.ServiceInterface
{
    public interface IUserService
    {
        Task<bool> RegisterUser(UserRegisterRequestModel userRegisterRequestModel);
        Task<LoginResponseModel> ValidateUser(LoginRequestModel loginRequestModel);
    }
}
