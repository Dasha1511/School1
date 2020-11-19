using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Pages.Studentss
{
    public class DeleteModel : PageModel
    {
        private readonly School.Data.SchoolContext _context;

        public DeleteModel(School.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Students Students { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Students = await _context.Students.FirstOrDefaultAsync(m => m.ID == id);

            if (Students == null)
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

            Students = await _context.Students.FindAsync(id);

            if (Students != null)
            {
                _context.Students.Remove(Students);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
