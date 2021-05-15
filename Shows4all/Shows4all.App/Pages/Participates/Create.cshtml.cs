using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;

namespace Shows4all.App.Pages.Participates
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
        ViewData["IdActor"] = new SelectList(_context.Actors, "Id", "Name");
        ViewData["IdEpisode"] = new SelectList(_context.Episodes, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Participate Participate { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Participates.Add(Participate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
