using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Shows4all.App.Data.Context;
using Shows4all.App.Data.Entities;

namespace Shows4all.App.Pages.Comments
{
    public class IndexModel : PageModel
    {
        private readonly Shows4all.App.Data.Context.Shows4AllDbContext _context;

        public IndexModel(Shows4all.App.Data.Context.Shows4AllDbContext context)
        {
            _context = context;
        }

        public string CommentSort { get; set; }

        public string PublishedDAteSort { get; set; }

        public string RatingSort { get; set; }

        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public IList<Comment> Comment { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            CommentSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            PublishedDAteSort = sortOrder == "Date" ? "date_desc" : "Date";
            RatingSort = String.IsNullOrEmpty(sortOrder) ? "rating_desc" : "";
           

            CurrentFilter = searchString;

            IQueryable<Comment> commentFilter = from s in _context.Comments
                                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                commentFilter = commentFilter.Where(s => s.Comments.ToUpper().Contains(searchString.ToUpper()) 
                || s.PublishedDAte.ToString().Contains(searchString)
                || s.Rating.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    commentFilter = commentFilter.OrderByDescending(s => s.Comments);
                    break;
                case "Date":
                    commentFilter = commentFilter.OrderBy(s => s.PublishedDAte);
                    break;
                case "date_desc":
                    commentFilter = commentFilter.OrderByDescending(s => s.PublishedDAte);
                    break;
                case "rating_desc":
                    commentFilter = commentFilter.OrderByDescending(s => s.Rating);
                    break;
                default:
                    commentFilter = commentFilter.OrderBy(s => s.Comments);
                    break;
            }



            Comment = await commentFilter.AsNoTracking()
                .Include(c => c.Customer)
                .Include(c => c.Serie).ToListAsync();
        }
    }
}
