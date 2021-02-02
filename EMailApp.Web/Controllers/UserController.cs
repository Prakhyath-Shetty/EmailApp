using EMailApp.Business;
using EMailApp.Common.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EMailApp.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserBusiness _userBuisness;
        public UserController(UserBusiness userBuisness)
        {
            this._userBuisness = userBuisness;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var user = await this._userBuisness.GetLoginUser(loginModel);
                if (user != null)
                {
                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.Name),
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
                        };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);

                    ViewBag.IsSuccess = true;

                    return RedirectToAction("Index", "Home");
                }
            }

            return View();

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme, new AuthenticationProperties()
            {
                ExpiresUtc = DateTimeOffset.Now,
                IsPersistent = false

            });

            return RedirectToAction("Login", "User");
        }
    }
}
