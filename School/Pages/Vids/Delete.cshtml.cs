﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Pages.Vids
{
    public class DeleteModel : PageModel
    {
        private readonly School.Data.SchoolContext _context;

        public DeleteModel(School.Data.SchoolContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vid Vid { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vid = await _context.Vid.FirstOrDefaultAsync(m => m.ID == id);

            if (Vid == null)
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

            Vid = await _context.Vid.FindAsync(id);

            if (Vid != null)
            {
                _context.Vid.Remove(Vid);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
