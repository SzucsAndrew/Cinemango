using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemango.Web.Pages.Admin
{
    public class TeremSzerkesztesModel : PageModel
    {
        public TeremService TeremService { get; }

        public TeremSzerkesztesModel( TeremService teremService)
        {
            TeremService = teremService;
        }

        [BindProperty( SupportsGet = true)]
        public int Id { get; set; }

        [BindProperty]
        public TeremSzerkesztes TeremModel { get; set; }

        public void OnGet()
        {
            var terem = TeremService.GetTerem(Id);
            TeremModel = new TeremSzerkesztes(Id, terem.Nev);
        }

        public IActionResult OnPost()
        {
            if( ModelState.IsValid)
            {
                TeremService.TeremSzerkeztes(TeremModel);
                return new RedirectToPageResult("/Admin/Termek");
            }

            return Page();
        }
    }
}
