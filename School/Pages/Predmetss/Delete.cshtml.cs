using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Pages.Predmetss
{
    public class DeleteModel : PageModel
    {
        private readonly School.Data.SchoolContext _context;

        public DeleteModel(School.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Predmets Predmets { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Predmets = await _context.Predmets.FirstOrDefaultAsync(m => m.ID == id);

            if (Predmets == null)
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

            Predmets = await _context.Predmets.FindAsync(id);

            if (Predmets != null)
            {
                _context.Predmets.Remove(Predmets);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
