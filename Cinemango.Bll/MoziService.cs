using Cinemango.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemango
{
    public class MoziService
    {
        public MoziService(MoziDbContext moziDbContext)
        {
            DbContext = moziDbContext;
        }

        public MoziDbContext DbContext { get; }

        public async Task<IReadOnlyCollection<VetitesUlohely>> GetUlohelyekForVetitesAsync(int vetitesId)
        {
            var vetites = await DbContext.Vetitesek.Include(v => v.Jegyek).ThenInclude(j => j.Ulohely).FirstOrDefaultAsync(v => v.Id == vetitesId);
            if (vetites == null)
                throw new InvalidOperationException($"A vetítés nem található: {vetitesId}.");

            var foglaltHelyek = vetites.Jegyek.Select(j => j.UlohelyId).ToHashSet();
            var teremUlohelyek = await DbContext.Ulohelyek.Where(u => u.TeremId == vetites.TeremId).ToListAsync();
            return teremUlohelyek.Select(t => new VetitesUlohely(t.Oldal, t.Sor, t.Szek, foglaltHelyek.Contains(t.Id))).ToList();
        }

        public async Task<IReadOnlyCollection<JegyTipus>> GetJegyTipusokAsync()
        {
            return await DbContext.JegyTipusok.Select(j => new JegyTipus(j.Id, j.Nev, j.Ar)).ToListAsync();
        }

        public async Task VasarlasAsync(int felhasznaloId, VasarlasStatusz statusz, IEnumerable<(int JegyTipusId, int UlohelyId, int VetitesId)> jegyek)
        {
            var jegyTipusArakById = await DbContext.JegyTipusok.ToDictionaryAsync(j => j.Id, j => j.Ar);
            if (await DbContext.Jegyek.AnyAsync(dbJegy => jegyek.Any(j => j.VetitesId == dbJegy.VetitesId && j.UlohelyId == dbJegy.UlohelyId)))
                throw new InvalidOperationException("A megadott vetítésen kiválasztott ülőhely már foglalt!");

            DbContext.Vasarlasok.Add(new Data.Entities.Vasarlas()
            {
                FelhasznaloId = felhasznaloId,
                Datum = DateTime.Now,
                Statusz = statusz,
                Jegyek = jegyek.Select(j => new Data.Entities.Jegy
                {
                    Ar = jegyTipusArakById[j.JegyTipusId],
                    TipusId = j.JegyTipusId,
                    UlohelyId = j.UlohelyId,
                    VetitesId = j.VetitesId
                }).ToList()
            });
            await DbContext.SaveChangesAsync();
        }
    }
}
