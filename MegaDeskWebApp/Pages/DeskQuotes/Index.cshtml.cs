using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskWebApp;
using MegaDeskWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MegaDeskWebApp.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskWebApp.Models.MegaDeskWebAppContext _context;
        [BindProperty(SupportsGet = true)]
        public string Result { get; set; }

        public IndexModel(MegaDeskWebApp.Models.MegaDeskWebAppContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Names { get; set; }
        [BindProperty(SupportsGet = true)]
        public string CustomerName { get; set; }

        public async Task OnGetAsync()
        {

            var entries = from m in _context.DeskQuote.Include(d => d.Desk) select m;
            if (Result == "Name")
            {
                entries = entries.OrderBy(b => b.CustomerName);
            }
            if (Result == "Date")
            {
                entries = entries.OrderBy(d => d.Date);
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                entries = entries.Where(m => m.CustomerName.Contains(SearchString));
            }

            DeskQuote = await entries.ToListAsync();

        }
    }
}
