using Cinemango.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Cinemango.Data
{
    public class MoziDbContext : IdentityDbContext<Felhasznalo, IdentityRole<int>, int>
    {
        public MoziDbContext(DbContextOptions<MoziDbContext> options) : base(options) { }

        public DbSet<Felhasznalo> Felhasznalok { get; set; }
        public DbSet<Film> Filmek { get; set; }
        public DbSet<Jegy> Jegyek { get; set; }
        public DbSet<JegyTipus> JegyTipusok { get; set; }
        public DbSet<Terem> Termek { get; set; }
        public DbSet<Ulohely> Ulohelyek { get; set; }
        public DbSet<Vasarlas> Vasarlasok { get; set; }
        public DbSet<Vetites> Vetitesek { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
