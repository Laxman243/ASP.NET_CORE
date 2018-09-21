using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPCore.Models;

namespace ASPCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ASPCore.Models.ASPCoreContext _context;

        public IndexModel(ASPCore.Models.ASPCoreContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
