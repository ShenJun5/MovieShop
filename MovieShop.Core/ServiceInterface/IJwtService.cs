using MovieShop.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Core.ServiceInterface
{
    public interface IJwtService
    {
        string GenerateJWT(LoginResponseModel userLoginResponse);
    }
}
