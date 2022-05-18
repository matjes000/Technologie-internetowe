using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TISklep.Models.Identity;

namespace TISklep.Controllers
{
    public class IdentityController : Controller
    {
        UserManager<AppUser> userManager { get; }

        SignInManager<AppUser> signInManager { get; }

        public IdentityController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IActionResult> Rejestracja()
        {
            var user = await userManager.FindByNameAsync("test");

            if (user == null)
            {
                AppUser userApp = new AppUser()
                {
                    UserName = "test",
                    Email = "test@test.pl",
                    FirstName = "test",
                    LastName = "test",
                    Password = "test1"
                };

                var result = await userManager.CreateAsync(userApp, userApp.Password);

                ViewBag.message("Uzytkownik utworzony! \n" + result);
            }
            else
            {
                ViewBag.message("Taki użytkownik już istnieje! \n");
            }

            return View();
        }

        public async Task<IActionResult> Logowanie()
        {
            var result = await signInManager.PasswordSignInAsync("test", "test1", false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.message = result;
            }

            return View();
        }

        public async Task<IActionResult> Wylogowanie()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
