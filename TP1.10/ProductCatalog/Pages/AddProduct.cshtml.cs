using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCatalog.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ProductCatalog.Pages
{
    public class AddProductModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty]
        public AdicionarProdduto AdicionarProdduto { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            Console.WriteLine(AdicionarProdduto);
        }

    }
}
