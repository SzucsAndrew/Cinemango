using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemango.Web.Pages.Admin.Filmek
{
    public class CreateModel : PageModel
    {
        public FilmService FilmService { get; }

        public CreateModel(FilmService filmService)
        {
            FilmService = filmService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public FilmDetails Film { get; set; }
        
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await FilmService.AddOrUpdateFilmDetails(Film);

            return RedirectToPage("./Index");
        }
    }
}
