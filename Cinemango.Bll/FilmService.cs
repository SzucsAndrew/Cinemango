using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Cinemango.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Cinemango
{
    public class FilmService
    {
        public MoziDbContext DbContext { get; }

        public FilmService(MoziDbContext dbContext)
        {
            DbContext = dbContext;
        }

        private Expression<Func<Data.Entities.Film, FilmDetails>> FilmDetailsSelector = f => new FilmDetails
        {
            Id = f.Id,
            ImdbId = f.ImdbId,
            Cim = f.Cim,
            ElozetesUrl = f.ElozetesUrl,
            EredetiCim = f.EredetiCim,
            KiadasEve = f.KiadasEve,
            LeirasHtml = f.LeirasHtml
        };

        public async Task<IEnumerable<Film>> GetFilmekAsync()
        {
            return (await DbContext.Filmek
                .Where(f => f.Vetitesek.Any(v => v.Idopont > DateTime.Now))
                .Select(f => new Film(f.Id, f.ImdbId, f.Cim, f.EredetiCim, f.KiadasEve, f.LeirasHtml, f.ElozetesUrl,
                                      f.Vetitesek.Where(v => v.Idopont > DateTime.Now).Select(v => new Vetites(v.Id, v.Idopont, v.TeremId, v.Terem.Nev, v.Tipus))))
                .ToListAsync())
                .OrderBy(f => f.Vetitesek.Select(v => v.Idopont).Where(i => i > DateTime.Now).OrderBy(i => i).FirstOrDefault())
                .ToList();
        }

        public async Task<IList<FilmDetails>> GetFilmekDetailsAsnyc()
        {
            return await DbContext.Filmek
                .Select(FilmDetailsSelector)
                .OrderBy(f => f.Cim)
                .ToListAsync();
        }

        public async Task<FilmDetails> GetFilmDetailsAsync(int id)
        {
            return await DbContext.Filmek
                .Where(f => f.Id == id)
                .Select(FilmDetailsSelector)
                .SingleOrDefaultAsync();
        }

        public async Task FilmTorlesAsync( int id)
        {
            DbContext.Filmek.Remove(new Data.Entities.Film { Id = id });
            await DbContext.SaveChangesAsync();
        }

        public async Task AddOrUpdateFilmDetails(FilmDetails filmDetails)
        {
            EntityEntry<Data.Entities.Film> entry;

            if (filmDetails.Id != 0)
                entry = DbContext.Entry(await DbContext.Filmek.FindAsync(filmDetails.Id));
            else
                entry = DbContext.Add(new Data.Entities.Film());

            entry.CurrentValues.SetValues(filmDetails);

            await DbContext.SaveChangesAsync();
        }

        //public async Task AddOrUpdateFilmDetails(FilmDetails filmDetails)
        //{
        //    Data.Entities.Film film = new Data.Entities.Film();
        //    if (filmDetails.Id != 0)
        //        film = await DbContext.Filmek.FindAsync(filmDetails.Id);

        //    film.ImdbId = filmDetails.ImdbId;
        //    film.Cim = filmDetails.Cim;
        //    film.EredetiCim = filmDetails.EredetiCim;
        //    film.KiadasEve = filmDetails.KiadasEve;
        //    film.ElozetesUrl = filmDetails.ElozetesUrl;
        //    film.LeirasHtml = filmDetails.LeirasHtml;

        //    if (filmDetails.Id == 0)
        //        DbContext.Filmek.Add(film);

        //    await DbContext.SaveChangesAsync();
        //}
    }
}
