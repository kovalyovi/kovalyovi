using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Title { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureTitle { get; set; }

        [BindProperty(SupportsGet = true)]
        public string myDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Notes { get; set; }


        public async Task OnGetAsync()
        {
            IQueryable<string> titleQuery = from s in _context.Scripture
                                            orderby s.Title
                                            select s.Title;

            var scriptures = from s in _context.Scripture
                             select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureTitle))
            {
                scriptures = scriptures.Where(x => x.Title == ScriptureTitle);
            }

            if (!string.IsNullOrEmpty(myDate))
            {
                scriptures = scriptures.Where(d => d.AddedDate == Convert.ToDateTime(myDate));
            }

            if (!string.IsNullOrEmpty(Notes))
            {
                scriptures = scriptures.Where(e => e.Notes.Contains(Notes));
            }


            Title = new SelectList(await titleQuery.Distinct().ToListAsync());
            Scripture = await scriptures.ToListAsync();
        }
    }
}
