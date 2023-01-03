using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cinemango.Data;
using Cinemango.Data.Entities;

namespace Cinemango.Web.Pages.Admin.Filmek
{
    public class DeleteModel : PageModel
    {
        public FilmService FilmService { get; }

        public DeleteModel(FilmService filmService)
        {
            FilmService = filmService;
        }

        [BindProperty]
        public FilmDetails Film { get; set; }
        

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            Film = await FilmService.GetFilmDetailsAsync( id.Value );

            if (Film == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
                return NotFound();

            await FilmService.FilmTorlesAsync( id.Value );

            return RedirectToPage("./Index");
        }
    }
}
