using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;
using Shows4all.App.Data.Repositories;

namespace Shows4all.App.Pages.Actors
{
    public class DeleteModel : PageModel
    {
        private readonly ActorRepository _actorRepository;

        public DeleteModel(ActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        [BindProperty]
        public Actor Actor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Actor = await _context.Actors.FirstOrDefaultAsync(m => m.Id == id);
            Actor = await _actorRepository.GetAsync(id.Value);

            if (Actor == null)
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

            //Actor = await _context.Actors.FindAsync(id);

            //if (Actor != null)
            //{
            //    _context.Actors.Remove(Actor);
            //    await _context.SaveChangesAsync();
            //}

            _ = await _actorRepository.DeleteActorAsync(id.Value);
            return RedirectToPage("./Index");
        }
    }
}
