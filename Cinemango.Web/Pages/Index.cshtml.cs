using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinemango.Web.Pages
{
    public class IndexModel : PageModel
    {
        public MoziService MoziService { get; }
        public FilmService FilmService { get; }

        public IndexModel(MoziService moziService, FilmService filmService)
        {
            MoziService = moziService;
            FilmService = filmService;
        }
        
        public IReadOnlyCollection<JegyTipus> JegyTipusok { get; private set; }
        public IEnumerable<Film> Filmek { get; private set; }

        public async Task OnGetAsync()
        {
            JegyTipusok = await MoziService.GetJegyTipusokAsync();
            Filmek = await FilmService.GetFilmekAsync();
        }
    }
}
