using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemango.Web.Pages.Admin.Filmek
{
    public class IndexModel : PageModel
    {
        public FilmService FilmService { get; }

        public IndexModel( FilmService filmService)
        {
            FilmService = filmService;
        }

        public IList<FilmDetails> Film { get;set; }

        public async Task OnGetAsync()
        {
            Film = await FilmService.GetFilmekDetailsAsnyc();
        }
    }
}
