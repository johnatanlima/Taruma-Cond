using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Taruma.BLL.Models;

namespace Taruma.DAL.Interfaces
{
    public interface IUserRepository : IRepositoryGeneric<User>
    {
        int HasRegister();

        Task UserLogin(User user, bool remember);

        Task IncludeUserLevel(User user, string level);

        Task<IdentityResult> CreateUser(User user, string pass);


    }
}
