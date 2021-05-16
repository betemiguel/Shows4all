using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shows4all.App.Data.Entities;
using Shows4all.App.Data.Repositories;


namespace Shows4all.App.Pages.Countries
{
    public class DeleteModel : PageModel
    {
        private readonly CountryRepository _countryRepository;

        public DeleteModel(CountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [BindProperty]
        public Country Country { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Country = await _countryRepository.GetAsync(id.Value);

            if (Country == null)
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

            _ = await _countryRepository.DeleteCountryAsync(id.Value);

            return RedirectToPage("./Index");
        }
    }
}
