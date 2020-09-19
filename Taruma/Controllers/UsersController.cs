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
                    string myPath = Path.Combine(_env.ContentRootPath, "wwwroot/Photos");
                    string photoName = Guid.NewGuid().ToString() + photo.FileName;

                    using (FileStream fs = new FileStream(Path.Combine(myPath, photoName), FileMode.Create))
                    {
                        await photo.CopyToAsync(fs);

                        registerVM.Photo = "~/Photos/" + photoName;
                    }
                }

                User user = new User();
                IdentityResult userCreated;

                if (_userRepository.HasRegister() == 0)
                {
                    //var retiraPonto = registerVM.CPF.Replace(".", "");
                    //var cpfValido = retiraPonto.Replace("-", "");

                    user.UserName = registerVM.Name;
                    //user.CPF = cpfValido.ToString();
                    user.CPF = registerVM.CPF;
                    user.Email = registerVM.Email;
                    user.PhoneNumber = registerVM.Phone;
                    user.Photo = registerVM.Photo;
                    user.Status = StatusAccount.Approved;
                    user.FirstAccess = false;

                    userCreated = await _userRepository.CreateUser(user, registerVM.Password);
                        
                    if (userCreated.Succeeded)
                    {
                        await _userRepository.IncludeUserLevel(user, "Administrator");
                        await _userRepository.UserLogin(user, false);

                        RedirectToAction("Home", "Index");
                    }
                }

                user.UserName = registerVM.Name;
                user.CPF = registerVM.CPF;
                user.Email = registerVM.Email;
                user.PhoneNumber = registerVM.Phone;
                user.Photo = registerVM.Photo;
                user.Status = StatusAccount.Analyzing;
                user.FirstAccess = true;

                userCreated = await _userRepository.CreateUser(user, registerVM.Password);

                if (userCreated.Succeeded)
                {
                    return View("Analyze", user.UserName);
                }
                else
                {
                    foreach (IdentityError erro in userCreated.Errors)
                    {
                        ModelState.AddModelError("", erro.Description);
                    }

                    return View(registerVM);
                }
            }

            return View(registerVM);
            
        }

        public IActionResult Analyze(string userNameParam)
        {
            return View(userNameParam);
        }


    }
}
