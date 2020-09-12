using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Taruma.BLL.Models;
using Taruma.DAL.Interfaces;
using Taruma.ViewModels;

namespace Taruma.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IWebHostEnvironment _env;

        public UsersController(IUserRepository userRepository, IWebHostEnvironment env)
        {
            _userRepository = userRepository;
            _env = env;
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

            if (ModelState.IsValid)
            {
                if (photo != null)
                {
                    string myPath = Path.Combine(_env.ContentRootPath, "Photos");
                    string photoName = Guid.NewGuid().ToString() + photo.FileName;

                    using (FileStream fs = new FileStream(Path.Combine(myPath, photoName), FileMode.Create))
                    {
                        await photo.CopyToAsync(fs);

                        registerVM.Photo = "~/Photos" + photoName;
                    }
                }

                User user = new User();
                IdentityUser userCreated;

                if(_userRepository.HasRegister() == 0)
                {
                    user.UserName = registerVM.Name;
                    user.CPF = registerVM.CPF;
                    user.Email = registerVM.Email;
                    user.PhoneNumber = registerVM.Phone;
                    user.Photo = registerVM.Photo;
                    user.Status = StatusAccount.Approved;
                    user.FirstAccess = false;


                }


                return View(registerVM);
            }
            
        }
    }
}
