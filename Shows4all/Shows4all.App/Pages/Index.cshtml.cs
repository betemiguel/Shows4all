using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Shows4all.App.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shows4all.App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Shows4AllDbContext _ctx;

        public IndexModel(ILogger<IndexModel> logger, Shows4AllDbContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public void OnGet()
        {

        }
    }
}
