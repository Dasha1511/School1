using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Models;

namespace School.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly School.Data.SchoolContext _context;

        public IndexModel(School.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; }
        public IList<Dolznost> Dolznost { get; set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
            Dolznost = await _context.Dolznost.ToListAsync();
        }
    }
}
