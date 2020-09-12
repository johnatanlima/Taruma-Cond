using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taruma.BLL.Models;
using Taruma.DAL.Interfaces;
using Taruma.ViewModels;

namespace Taruma.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepo;
        private readonly IWebHostEnvironment _env;

        public UsersController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerVM, IFormFile photo)
        {
            
        }
    }
}
