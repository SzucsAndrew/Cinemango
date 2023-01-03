using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemango.Web.Pages.Admin
{
    public class TeremLetrehozasModel : PageModel
    {
        public TeremService TeremService { get; }

        public TeremLetrehozasModel( TeremService teremService)
        {
            TeremService = teremService;
        }

        [BindProperty]
        public TeremLetrehozas TeremModel { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if( ModelState.IsValid)
            {
                TeremService.TeremLetrehozas(TeremModel);
                return new RedirectToPageResult("/Admin/Termek");
            }

            return Page();
        }
    }
}
