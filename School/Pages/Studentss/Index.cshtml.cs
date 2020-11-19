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
    public class IndexModel : PageModel
    {
        private readonly School.Data.SchoolContext _context;

        public IndexModel(School.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}
