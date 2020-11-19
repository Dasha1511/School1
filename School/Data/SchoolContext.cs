using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<School.Models.Staff> Staff { get; set; }

        public DbSet<School.Models.Dolznost> Dolznost { get; set; }

        public DbSet<School.Models.Students> Students { get; set; }

        public DbSet<School.Models.Class> Class { get; set; }

        public DbSet<School.Models.Vid> Vid { get; set; }

        public DbSet<School.Models.Predmets> Predmets { get; set; }

        public DbSet<School.Models.Raspisanie> Raspisanie { get; set; }
    }
}
