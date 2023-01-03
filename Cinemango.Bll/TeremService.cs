using System.Collections.Generic;
using System.Linq;
using Cinemango.Data;
using Cinemango.Data.Entities;

namespace Cinemango
{
    public class TeremService
    {
        public MoziDbContext MoziDbContext { get; }

        public TeremService(MoziDbContext moziDbContext)
        {
            MoziDbContext = moziDbContext;
        }

        public List<Terem> Termek()
        {
            return MoziDbContext.Termek
                .Select(t => new Terem(t.Id, t.Nev, t.Ulohelyek.Count))
                .ToList();
        }

        public void TeremTorles(int id)
        {
            MoziDbContext.Termek.Remove(new Data.Entities.Terem { Id = id });
            MoziDbContext.SaveChanges();
        }

        public Terem GetTerem(int id)
        {
            return MoziDbContext.Termek
                .Where(t => t.Id == id)
                .Select(t => new Terem(t.Id, t.Nev, t.Ulohelyek.Count))
               .Single();
        }

        public void TeremSzerkeztes(TeremSzerkesztes model)
        {
            var terem = MoziDbContext.Termek.Single(t => t.Id == model.Id);
            terem.Nev = model.Nev;
            MoziDbContext.SaveChanges();
        }

        public void TeremLetrehozas(TeremLetrehozas model)
        {
            var ujTerem = new Data.Entities.Terem
            {
                Nev = model.Nev
            };

            List<Ulohely> ulohelyek = new List<Ulohely>();
            for (int sor = 1; sor <= model.Sorok; sor++)
            {
                for (int oszlop = 1; oszlop <= model.Szekek; oszlop++)
                {
                    var ulohely = new Ulohely { Sor = sor, Szek = oszlop, Terem = ujTerem };
                    ulohelyek.Add(ulohely);
                }
            }

            ujTerem.Ulohelyek = ulohelyek;

            MoziDbContext.Termek.Add(ujTerem);
            MoziDbContext.SaveChanges();
        }
    }
}
