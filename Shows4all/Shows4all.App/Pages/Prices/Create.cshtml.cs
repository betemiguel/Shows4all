using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;

namespace Shows4all.App.Pages.Prices
{
    public class CreateModel : PageModel
    {
        private readonly Shows4all.App.Data.Context.Shows4AllDbContext _context;

        public CreateModel(Shows4all.App.Data.Context.Shows4AllDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Serie"] = new SelectList(_context.Serie, "Id", "Name", "Price");
            return Page();
        }

        [BindProperty]
        public PriceSeries PriceSeries { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.PricesSeries.Add(PriceSeries);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
