using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shows4all.App.Data.Entities;
using Shows4all.App.Data.Repositories;

namespace Shows4all.App.Pages.Countries
{
    public class CreateModel : PageModel
    {
        private readonly CountryRepository _countryRepository;

        public CreateModel(CountryRepository countryRepository )
        {
            _countryRepository = countryRepository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Country Country { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var country = await _countryRepository.AddCountryAsync(Country);
            

            return RedirectToPage("./Index");
        }
    }
}
