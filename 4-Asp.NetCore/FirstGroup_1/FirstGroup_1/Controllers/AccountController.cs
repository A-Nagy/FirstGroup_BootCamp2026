using FirstGroup_1.Data;
using FirstGroup_1.Models;
using FirstGroup_1.Models.ViewModels;
using FirstGroup_1.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security;
using System.Security.Claims;

namespace FirstGroup_1.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            if (User.Identity?.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ReturnUrl = returnUrl;

            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model , string? returnUrl = null)
        {
            if (!ModelState.IsValid) 
            {
                ViewBag.ReturnUrl = returnUrl;
                return View(model);
            }
            User? user = _context.Users.Include(u => u.Roles).
                                        ThenInclude(r => r.Permissions)
                                        .FirstOrDefault(u => u.Username == model.Username);
            if (user == null) 
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                ViewBag.ReturnUrl = returnUrl;
                return View(model);
            }
            if(user.Password != model.Password) 
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
                ViewBag.ReturnUrl = returnUrl;
                return View(model);
            }
            // Authentication logic here (e.g., creating claims, signing in the user)
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name          , user.Name),
                new Claim(ClaimTypes.Email         , user.Email ?? string.Empty),
                new Claim("Username"               , user.Username)
            };
            //Add role claims
            foreach (var role in user?.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Name));
            }

            //Add permission claims
            List<string> permissions = 
                user.Roles.SelectMany(r => r.Permissions).Select(p=>p.Name).Distinct().ToList();

            foreach (string permission in permissions)
            {
                claims.Add(new Claim(PermissionsNames.ClaimType, permission));
            }
            //Create the identity and principal
            ClaimsIdentity identity 
                = new ClaimsIdentity(claims,
                                     CookieAuthenticationDefaults.AuthenticationScheme,
                                     ClaimTypes.Name,
                                     ClaimTypes.Role);

            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            //Cookie authentication properties
            AuthenticationProperties properties = new AuthenticationProperties
            {
                IsPersistent = model.RememberMe,
                ExpiresUtc   = DateTimeOffset.UtcNow.AddMinutes(30)
            };

            //Sign in the user
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                    principal, properties);
            //Redirect to the return URL or home page
           
            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index","Home");
        }
       
        [Authorize]
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
        public IActionResult MyAccess()
        {
            return View();
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        }
}
