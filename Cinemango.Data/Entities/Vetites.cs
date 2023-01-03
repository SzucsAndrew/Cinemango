using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Cinemango.Data.Entities
{
    public class Vetites : IEntityTypeConfiguration<Vetites>
    {
        public int Id { get; set; }
        public DateTime Idopont { get; set; }
        public VetitesTipus Tipus { get; set; }

        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int TeremId { get; set; }
        public Terem Terem { get; set; }
        public ICollection<Jegy> Jegyek { get; set; }

        public void Configure(EntityTypeBuilder<Vetites> builder)
        {
            builder.HasOne(v => v.Film).WithMany(f => f.Vetitesek)
                .HasForeignKey(v => v.FilmId).HasPrincipalKey(f => f.Id);
        }
    }
}
