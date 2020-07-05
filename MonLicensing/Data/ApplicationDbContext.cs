using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MonLicensing.Models;

namespace MonLicensing.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<EducationalPrograms> EducationalPrograms { get; set; }
        public DbSet<Conclusions> Conclusions { get; set; }
        public DbSet<LegalForm> LegalForm { get; set; }
        public DbSet<Denial> Denial { get; set; }
        public DbSet<Reissuining> Reissuining { get; set; }
        public DbSet<ImpactMeasures> ImpactMeasures { get; set; }


        public DbSet<Processes> Processes { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<SobsForm> SobsForm { get; set; }
        public DbSet<Request> Request { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
