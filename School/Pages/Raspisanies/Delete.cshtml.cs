using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Pages.Raspisanies
{
    public class DeleteModel : PageModel
    {
        private readonly School.Data.SchoolContext _context;

        public DeleteModel(School.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Raspisanie Raspisanie { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Raspisanie = await _context.Raspisanie.FirstOrDefaultAsync(m => m.ID == id);

            if (Raspisanie == null)
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

            Raspisanie = await _context.Raspisanie.FindAsync(id);

            if (Raspisanie != null)
            {
                _context.Raspisanie.Remove(Raspisanie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
