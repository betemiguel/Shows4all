using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Shows4all.App.Data.Context;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Shows4all.App.Models;

namespace Shows4all.App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Shows4AllDbContext _ctx;
        private readonly IConfiguration configuration;

        public IndexModel(ILogger<IndexModel> logger, Shows4AllDbContext ctx, IConfiguration configuration)
        {
            _logger = logger;
            _ctx = ctx;
            this.configuration = configuration;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public string UserName { get; set; }
        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }
        public string Message { get; set; }
        public async Task<IActionResult> OnPost()
        {
            var admin = configuration.GetSection("AdminUser").Get<AdminUser>();
            var user = configuration.GetSection("SiteUser").Get<SiteUser>();

            if (UserName == admin.UserName)
            {
                
                if (Password == admin.Password )
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, UserName)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("/User/Index");
                }
            }

            if (UserName == user.UserName)
            {
               
                if (Password == user.Password)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, UserName)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("/Client/index");
                }
            }
            Message = "Invalid attempt";
            return Page();
        }


    }
}
