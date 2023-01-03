using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinemango.Web.Pages.Admin
{
    public class TermekModel : PageModel
    {
        public TeremService TeremService { get; }

        public TermekModel( TeremService teremService)
        {
            TeremService = teremService;
        }

        public List<Terem> Termek { get; set; }

        public void OnGet()
        {
            Termek = TeremService.Termek();
        }

        public IActionResult OnPost(int id)
        {
            System.Threading.Thread.Sleep(3000);

            TeremService.TeremTorles(id);

            return new JsonResult(new { url = "reload" });
        }
    }
}
