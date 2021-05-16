using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;

namespace Shows4all.App.Pages.ViewSeries
{
    public class IndexModelClient : PageModel
    {
        private readonly Shows4all.App.Data.Context.Shows4AllDbContext _context;

        public IndexModelClient(Shows4all.App.Data.Context.Shows4AllDbContext context)
        {
            _context = context;
        }


        public string NameSort { get; set; }
        public string ReleaseDateSort { get; set; }
        public string GenreSort { get; set; }

        public string CountrySort { get; set; }

        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public IList<Serie> Serie { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ReleaseDateSort = sortOrder == "Date" ? "date_desc" : "Date";
            GenreSort = String.IsNullOrEmpty(sortOrder) ? "genre_desc" : "";
            CountrySort = String.IsNullOrEmpty(sortOrder) ? "country_desc" : "";

            CurrentFilter = searchString;

            IQueryable<Serie> seriesName = from s in _context.Serie
                                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                seriesName = seriesName.Where(s => s.Name.ToUpper().Contains(searchString.ToUpper()) || s.ReleaseDate.ToString().Contains(searchString.ToUpper())
                                       || s.Genre.Name.Contains(searchString) || s.Country.Name.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    seriesName = seriesName.OrderByDescending(s => s.Name);
                    break;
                case "Date":
                    seriesName = seriesName.OrderBy(s => s.ReleaseDate);
                    break;
                case "date_desc":
                    seriesName = seriesName.OrderByDescending(s => s.ReleaseDate);
                    break;
                case "genre_desc":
                    seriesName = seriesName.OrderByDescending(s => s.Genre);
                    break;
                case "country_desc":
                    seriesName = seriesName.OrderByDescending(s => s.Country);
                    break;
                default:
                    seriesName = seriesName.OrderBy(s => s.Name);
                    break;
            }

            Serie = await seriesName.AsNoTracking()
                .Include(s => s.Country)
                .Include(s => s.Genre).ToListAsync();
        }
    }
}
