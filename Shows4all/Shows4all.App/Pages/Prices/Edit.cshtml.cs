using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;

namespace Shows4all.App.Pages.Prices
{
    public class EditModel : PageModel
    {
        private readonly Shows4all.App.Data.Context.Shows4AllDbContext _context;

        public EditModel(Shows4all.App.Data.Context.Shows4AllDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PriceSeries PriceSeries { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            PriceSeries = await _context.PricesSeries
                .Include(p => p.Serie).FirstOrDefaultAsync(m => m.Id == id);

            if (PriceSeries == null)
            {
                return NotFound();
            }
           ViewData["IdSerie"] = new SelectList(_context.Serie, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(PriceSeries).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PriceSeriesExists(PriceSeries.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PriceSeriesExists(int id)
        {
            return _context.PricesSeries.Any(e => e.Id == id);
        }
    }
}
