using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Cinemango.Data.Entities
{
    public class Vasarlas : IEntityTypeConfiguration<Vasarlas>
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public VasarlasStatusz Statusz { get; set; }

        public int FelhasznaloId { get; set; }
        public Felhasznalo Felhasznalo { get; set; }
        public ICollection<Jegy> Jegyek { get; set; }

        public void Configure(EntityTypeBuilder<Vasarlas> builder)
        {
            builder.HasOne(v => v.Felhasznalo).WithMany(f => f.Vasarlasok)
                .HasForeignKey(v => v.FelhasznaloId).HasPrincipalKey(f => f.Id);
        }
    }
}
