using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Shows4all.App.Pages.ViewSeries
{
    public class IndexModelClient : PageModel
    {
        private readonly Shows4AllDbContext _context;

        public IndexModelClient(Shows4AllDbContext context)
        {
            _context = context;
        }


        public string NameSort { get; set; }
        public string ReleaseDateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Serie> Serie { get; set; }


        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ReleaseDateSort = sortOrder == "Date" ? "date_desc" : "Date";

            CurrentFilter = searchString;

            IQueryable<Serie> seriesName = from s in _context.Serie
                                             select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                seriesName = seriesName.Where(s => s.Name.ToUpper().Contains(searchString.ToUpper())
                                       || s.Description.Contains(searchString));
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
                default:
                    seriesName = seriesName.OrderBy(s => s.Name);
                    break;
            }

            Serie = await seriesName.AsNoTracking().ToListAsync();
        }
    }
}
    

