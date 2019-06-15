using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskWebApp;
using MegaDeskWebApp.Models;

namespace MegaDeskWebApp.Pages.DeskQuotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskWebApp.Models.MegaDeskWebAppContext _context;

        public CreateModel(MegaDeskWebApp.Models.MegaDeskWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DeskID"] = new SelectList(_context.Set<Desk>(), "DeskID", "DeskID");
            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            DeskQuote.QuotePrice = getPrice();

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private int getPrice()
        {
            var myDesk = DeskQuote.Desk;
            float area = myDesk.Width * myDesk.Depth;
            float extraArea = (area > 1000 ? (area - 1000) * 1 : 0);
            return (int)(200 + 50 * myDesk.NumberOfDrawers + extraArea + 
                MaterialPrice.GetMaterialPrice(myDesk.SurfaceMaterial) + 
                RushOrder.CalculateRushOrder(DeskQuote.RushOptions, (int)area));
        }

    }
}