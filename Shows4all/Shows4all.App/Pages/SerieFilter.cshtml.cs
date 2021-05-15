using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shows4all.App.Pages
{
   
    public class FilterSeriesModel  : PageModel
    {
        private readonly Shows4AllDbContext _ctx;

        public FilterSeriesModel(Shows4AllDbContext ctx)
        {
            _ctx = ctx;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public string SerieFilter { get; set; }

        public List<Serie> Series { get; set; }

        public void OnPost()
        {
            var filtro = SerieFilter;

            Series = _ctx.Serie.Where(u => u.Name.Contains(SerieFilter)).ToList();
        }
    }
}
