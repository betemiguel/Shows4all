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

namespace Shows4all.App.Pages.User
{
    public class DeleteModel : PageModel
    {
        private readonly AdminRepository _adminRepository;

        public DeleteModel(AdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        [BindProperty]
        public Admin Admin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Admin = await _adminRepository.GetAsync(id.Value);

            if (Admin == null)
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



            _ = await _adminRepository.DeleteAdminAsync(id.Value);
            return RedirectToPage("./Index");
        }
    }
}
