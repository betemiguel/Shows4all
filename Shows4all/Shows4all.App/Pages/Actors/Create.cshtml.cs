using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;
using Shows4all.App.Data.Repositories;

namespace Shows4all.App.Pages.Actors
{
    public class CreateModel : PageModel
    {
        
        private readonly ActorRepository _actorRepository;

        public CreateModel( ActorRepository actorRepository)
        {
           
           _actorRepository = actorRepository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Actor Actor { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var actor = await _actorRepository.AddActorAsync(Actor);
           

            return RedirectToPage("./Index");
        }
    }
}
