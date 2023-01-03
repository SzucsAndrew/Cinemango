using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Cinemango.Data.Entities
{
    public class Film : IEntityTypeConfiguration<Film>
    {
        public int Id { get; set; }
        public string ImdbId { get; set; }
        public string Cim { get; set; }
        public string EredetiCim { get; set; }
        public int KiadasEve { get; set; }
        public string LeirasHtml { get; set; }
        public string? ElozetesUrl { get; set; }
        public byte[]? Boritokep { get; set; }

        public ICollection<Vetites> Vetitesek { get; set; }

        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.Property(f => f.ImdbId).HasMaxLength(10);
            builder.HasIndex(f => f.ImdbId).IsUnique();
        }
    }
}
