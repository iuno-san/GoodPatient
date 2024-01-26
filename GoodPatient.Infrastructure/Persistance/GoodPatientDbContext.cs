using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodPatient.Infrastructure.Persistance
{
    public class GoodPatientDbContext : IdentityDbContext
    {
        public GoodPatientDbContext(DbContextOptions<GoodPatientDbContext> options): base(options) 
        {

        }   
        public DbSet<Domain.Entities.GoodPatient> GoodPatients { get; set; }
        public DbSet<Domain.Entities.GoodPatientEarnings> GoodPatientEarnings { get; set; }
        public DbSet<Domain.Entities.GoodPatientService> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Domain.Entities.GoodPatient>()
                .HasMany(m => m.Services)
                .WithOne(s => s.GoodPatient)
                .HasForeignKey(s => s.GoodPatientId);
        }
    }
}
