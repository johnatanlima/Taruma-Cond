using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Taruma.BLL.Models;
using Taruma.DAL.Interfaces;

namespace Taruma.DAL.Repositories
{
    public class UserRepository : RepositoryGeneric<User>, IUserRepository
    {
        private readonly Context _context;
        private readonly UserManager<User> _userManag;
        private readonly SignInManager<User> _loginManag;
        
        public UserRepository(Context context, UserManager<User> userManag, SignInManager<User> loginManag) : base(context)
        {
            _context = context;
            _userManag = userManag;
            _loginManag = loginManag;
        }

        public async Task<IdentityResult> CreateUser(User user, string pass)
        {
            try
            {
                return await _userManag.CreateAsync(user, pass);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task IncludeUserLevel(User user, string level)
        {
            try
            {
                await _userManag.AddToRoleAsync(user, level);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task UserLogin(User user, bool remember)
        {
            try
            {
                await _loginManag.SignInAsync(user, remember);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task UserLogout()
        {
            try
            {
                await _loginManag.SignOutAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int HasRegister()
        {
            try
            {
                return _context.Users.Count();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<User> GerUserByEmail(string email)
        {
            try
            {
                return await _userManag.FindByEmailAsync(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task UserUpdate(User user)
        {
            try
            {
                await _userManag.UpdateAsync(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<bool> UserInLevel(User user, string level)
        {
            try
            {
                return await _userManag.IsInRoleAsync(user, level);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IList<string>> GetLevelUser(User user)
        {
            try
            {
                return await _userManag.GetRolesAsync(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IdentityResult> UserLevelRemove(User user, IEnumerable<string> levels)
        {
            try
            {
                return await _userManag.RemoveFromRolesAsync(user, levels);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IdentityResult> IncludeUserInLevel(User user, IEnumerable<string> levels)
        {
            try
            {
                return await _userManag.AddToRolesAsync(user, levels);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<User> GetUserByName(ClaimsPrincipal user)
        {
            try
            {
                return await _userManag.FindByNameAsync(user.Identity.Name);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<User> GetUserById(string userId)
        {
            try
            {
                return await _userManag.FindByIdAsync(userId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string HasherPass(User usuario, string pass)
        {
            try
            {
                return _userManag.PasswordHasher.HashPassword(usuario, pass);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
