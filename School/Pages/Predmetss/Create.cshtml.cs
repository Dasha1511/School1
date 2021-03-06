﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using School.Data;
using School.Models;

namespace School.Pages.Predmetss
{
    public class CreateModel : PageModel
    {
        private readonly School.Data.SchoolContext _context;

        public CreateModel(School.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Predmets Predmets { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Predmets.Add(Predmets);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
