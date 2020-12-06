using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miniProjet1.Modele;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace miniProjet1.Pages
{
    public class AjoutPModel : PageModel
    {
        private readonly miniProjet1DbContext _db;

        public AjoutPModel(miniProjet1DbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Professeur Professeur { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Professeurs.Add(Professeur);
            await _db.SaveChangesAsync();

            return RedirectToPage("./IndexP");
        }
    }
}