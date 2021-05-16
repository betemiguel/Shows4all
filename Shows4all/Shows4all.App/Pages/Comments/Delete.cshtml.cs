using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;

namespace Shows4all.App.Pages.Comments
{
    public class DeleteModel : PageModel
    {
        private readonly Shows4all.App.Data.Context.Shows4AllDbContext _context;

        public DeleteModel(Shows4all.App.Data.Context.Shows4AllDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Comment Comment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Comment = await _context.Comments
                .Include(c => c.Customer)
                .Include(c => c.Serie).FirstOrDefaultAsync(m => m.Id == id);

            if (Comment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Comment = await _context.Comments.FindAsync(id);

            if (Comment != null)
            {
                _context.Comments.Remove(Comment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
