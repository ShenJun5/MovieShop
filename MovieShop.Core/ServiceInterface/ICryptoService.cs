using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Core.ServiceInterface
{
    public interface ICryptoService
    {
        string GenerateRandomSalt();
        string HashPassword(string password, string salt);
    }
}
