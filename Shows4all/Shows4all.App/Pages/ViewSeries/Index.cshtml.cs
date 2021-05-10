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
    public class IndexModelClient: PageModel
    {
        private readonly Shows4all.App.Data.Context.Shows4AllDbContext _context;

        public IndexModelClient(Shows4all.App.Data.Context.Shows4AllDbContext context)
        {
            _context = context;
        }

        public IList<Serie> Serie { get;set; }

        public async Task OnGetAsync()
        {
            Serie = await _context.Serie
                .Include(s => s.Season).ToListAsync();
        }
    }
}
