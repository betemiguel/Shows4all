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
using Shows4all.App.Data.Entities;
using System.Linq;

namespace Shows4all.App.Pages
{
    public class IndexModelFilter : PageModel
    {
        
        private readonly Shows4AllDbContext _ctx;
       

        public IndexModelFilter(ILogger<IndexModel> logger, Shows4AllDbContext ctx, IConfiguration configuration)
        {
          
            _ctx = ctx;
           
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public string CreditCardFilter { get; set; }

        public List<CreditCardPayment> CreditCardPayment { get; set; }

        public void OnPost()
        {
            var filtro = CreditCardFilter;

            CreditCardPayment = _ctx.CreditCardsPayment.Where(u => u.CardName.Contains(CreditCardFilter)).ToList();
        }

      

    }
}
