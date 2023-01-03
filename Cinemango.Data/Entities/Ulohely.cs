using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Cinemango.Data.Entities
{
    public class Ulohely : IEntityTypeConfiguration<Ulohely>
    {
        public int Id { get; set; }
        public UlohelyOldal? Oldal { get; set; }
        public int Sor { get; set; }
        public int Szek { get; set; }

        public int TeremId { get; set; }
        public Terem Terem { get; set; }
        public ICollection<Jegy> Jegyek { get; set; }

        public void Configure(EntityTypeBuilder<Ulohely> builder)
        {
            builder.HasIndex(u => new { u.TeremId, u.Oldal, u.Sor, u.Szek }).IsUnique();

            builder.HasOne(u => u.Terem).WithMany(t => t.Ulohelyek)
                .HasForeignKey(u => u.TeremId).HasPrincipalKey(t => t.Id);
        }
    }
}
