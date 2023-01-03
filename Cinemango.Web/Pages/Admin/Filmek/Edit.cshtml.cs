using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cinemango.Data;
using Cinemango.Data.Entities;

namespace Cinemango.Web.Pages.Admin.Filmek
{
    public class EditModel : PageModel
    {
        public FilmService FilmService { get; }

        public EditModel( FilmService filmService)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await FilmService.AddOrUpdateFilmDetails(Film);
            return RedirectToPage("./Index");
        }
    }
}
