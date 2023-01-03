using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Cinemango.Data.Entities
{
    public class JegyTipus : IEntityTypeConfiguration<JegyTipus>
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int Ar { get; set; }
        public ICollection<Jegy> Jegyek { get; set; }

        public void Configure(EntityTypeBuilder<JegyTipus> builder)
        {
            builder.Property(jt => jt.Nev).HasMaxLength(20);
            builder.HasIndex(jt => jt.Nev).IsUnique();
        }
    }
}
