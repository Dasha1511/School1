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
    public class IndexModel : PageModel
    {
        private readonly School.Data.SchoolContext _context;

        public IndexModel(School.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }
        public IList<Vid> Vid { get; set; }
        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
            Vid = await _context.Vid.ToListAsync();
        }
    }
}
