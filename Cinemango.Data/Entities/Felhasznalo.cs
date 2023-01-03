using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Cinemango.Data.Entities
{
    public class Felhasznalo : IdentityUser<int>, IEntityTypeConfiguration<Felhasznalo>
    {
        public string TeljesNev { get; set; }

        public ICollection<Vasarlas> Vasarlasok { get; set; }

        public void Configure(EntityTypeBuilder<Felhasznalo> builder)
        {
            builder.ToTable("Felhasznalo");
            builder.Property(f => f.TeljesNev).HasMaxLength(100);
        }
    }
}
