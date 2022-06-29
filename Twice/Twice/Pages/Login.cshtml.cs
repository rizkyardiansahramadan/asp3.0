using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Twice.Model;

namespace Twice.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }
        public string Message { get; set; }


        private readonly IConfiguration configuration;
        public LoginModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task<IActionResult> OnPost()
        {
            var user = configuration.GetSection("USER").Get<User>();
                if (Email == user.Email)
                {
                    var passwordHasher = new PasswordHasher<string>();
                    if(passwordHasher.VerifyHashedPassword(null, user.Password, Password)
                    == PasswordVerificationResult.Success)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,Email)

                    };
                    var claimsIdentity = new ClaimsIdentity(claims,
                        CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("/Index");
                }

                }
            Message = "Invalid attempt";
            return Page();
        }// end login
        
        public void OnGet()
        {
        }
    }
}
