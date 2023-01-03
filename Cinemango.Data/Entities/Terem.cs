using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Cinemango.Data.Entities
{
    public class Terem : IEntityTypeConfiguration<Terem>
    {
        public int Id { get; set; }
        public string Nev { get; set; }

        public ICollection<Ulohely> Ulohelyek { get; set; }
        public ICollection<Vetites> Vetitesek { get; set; }

        public void Configure(EntityTypeBuilder<Terem> builder)
        {
            builder.Property(t => t.Nev).HasMaxLength(20);
            builder.HasIndex(t => t.Nev).IsUnique();
        }
    }
}
