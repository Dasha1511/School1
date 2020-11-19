using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Pages.Classs
{
    public class DeleteModel : PageModel
    {
        private readonly School.Data.SchoolContext _context;

        public DeleteModel(School.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Class Class { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class = await _context.Class.FirstOrDefaultAsync(m => m.ID == id);

            if (Class == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class = await _context.Class.FindAsync(id);

            if (Class != null)
            {
                _context.Class.Remove(Class);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
