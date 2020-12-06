using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using miniProjet1.Modele;

namespace miniProjet1.Pages
{
    public class AjoutSModel : PageModel
    {
        private readonly miniProjet1DbContext _db;
        public IEnumerable<Matiere> ML { get; set; }
        public AjoutSModel(miniProjet1DbContext db)
        {
            _db = db;
            ML = _db.Matieres.ToList();

        }

        [BindProperty]
        public Seance Seance { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Seances.Add(Seance);
            await _db.SaveChangesAsync();

            return RedirectToPage("./IndexS");
        }
    }
}
