using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Core.ServiceInterface
{
    public interface ICurrentLogedInUser
    {
        bool IsAuthenticated { get; }
        string FullName { get; }
        string Email { get; }
        List<string> Roles { get; }
        bool IsAdmin { get; }
        bool IsSuperAdmin { get; }
        int UserId { get; }
    }
}
