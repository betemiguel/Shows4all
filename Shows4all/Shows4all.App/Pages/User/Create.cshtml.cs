using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shows4all.App.Data.Entities;
using Shows4all.App.Data.Repositories;

namespace Shows4all.App.Pages.User
{
    public class CreateModel : PageModel
    {
        private readonly AdminRepository _adminRepository;

        public CreateModel(AdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Admin Admin { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var admin = await _adminRepository.AddAdminAsync(Admin);
            

            return RedirectToPage("./Index");
        }
    }
}
