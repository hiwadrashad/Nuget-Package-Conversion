using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuget_Library.Extension_Methods;
using Nuget_Library.Encryption;
using Nuget_Frontend.Data;

namespace Nuget_Frontend.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            Models.Login LoginModel = new Models.Login();
            return View(LoginModel);
        }

        [HttpPost]
        public IActionResult Login(Models.Login LoginModel)
        {
            
            if (!LoginModel.Username.IsNullOrWhiteSpace())
            {
                var test1 = LoginModel.Username == UserData.username;
                var test2 = SaltingAndHashing.CompareHash(LoginModel.Password, UserData.hash, UserData.salt);
                if (LoginModel.Username == UserData.username && SaltingAndHashing.CompareHash(LoginModel.Password, UserData.hash, UserData.salt))
                {
                    return RedirectToAction("Success");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }


        public IActionResult Success() 
        {
            return View();
        }
    }
}
