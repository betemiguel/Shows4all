using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;

namespace Shows4all.App.Pages.Rentals
{
    public class IndexModel : PageModel
    {
        private readonly Shows4AllDbContext _context;

        public IndexModel(Shows4AllDbContext context)
        {
            _context = context;
        }

        public string DateRentedSort { get; set; }
        public string SerieSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Rental> Rental { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            

            ViewData["SerieSort"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateRentedSort"] = sortOrder == "Date" ? "date_desc" : "Date";
          
            ViewData["CurrentFilter"] = searchString;

            IQueryable<Rental> rentalFilter = from s in _context.Rentals
                                              select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                rentalFilter = rentalFilter.Where(s => s.Serie.Name.ToUpper().Contains(searchString.ToUpper())
                || s.DateRented.ToString().Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    rentalFilter = rentalFilter.OrderByDescending(s => s.Serie);
                    break;
                case "Date":
                    rentalFilter = rentalFilter.OrderBy(s => s.DateRented);
                    break;
                case "date_desc":
                    rentalFilter = rentalFilter.OrderByDescending(s => s.DateRented);
                    break;
                default:
                    rentalFilter = rentalFilter.OrderBy(s => s.Serie);
                    break;
            }



            Rental = await rentalFilter.AsNoTracking()
                .Include(r => r.Serie).ToListAsync();
        }


       
    }
}
