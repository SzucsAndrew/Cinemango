using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cinemango.Data.Entities
{
    public class Jegy : IEntityTypeConfiguration<Jegy>
    {
        public int Id { get; set; }
        public int? Ar { get; set; }

        public int? TipusId { get; set; }
        public JegyTipus? Tipus { get; set; }
        public int UlohelyId { get; set; }
        public Ulohely Ulohely { get; set; }
        public int? VasarlasId { get; set; }
        public Vasarlas? Vasarlas { get; set; }
        public int VetitesId { get; set; }
        public Vetites Vetites { get; set; }

        public void Configure(EntityTypeBuilder<Jegy> builder)
        {
            builder.HasIndex(j => new { j.UlohelyId, j.VetitesId }).IsUnique();

            builder.HasOne(j => j.Tipus).WithMany(jt => jt.Jegyek)
                .HasForeignKey(j => j.TipusId).HasPrincipalKey(jt => jt.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(j => j.Ulohely).WithMany(u => u.Jegyek)
                .HasForeignKey(j => j.UlohelyId).HasPrincipalKey(u => u.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(j => j.Vasarlas).WithMany(v => v.Jegyek)
                .HasForeignKey(j => j.VasarlasId).HasPrincipalKey(v => v.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(j => j.Vetites).WithMany(v => v.Jegyek)
                .HasForeignKey(j => j.VetitesId).HasPrincipalKey(v => v.Id);

        }
    }
}
