using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;

namespace Shows4all.App.Pages.CreditCards
{
    public class DetailsModel : PageModel
    {
        private readonly Shows4all.App.Data.Context.Shows4AllDbContext _context;

        public DetailsModel(Shows4all.App.Data.Context.Shows4AllDbContext context)
        {
            _context = context;
        }

        public CreditCardPayment CreditCardPayment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CreditCardPayment = await _context.CreditCardsPayment
                .Include(c => c.Customer).FirstOrDefaultAsync(m => m.Id == id);

            if (CreditCardPayment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
