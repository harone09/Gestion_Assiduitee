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
    public class AjoutMModel : PageModel
    {
        private readonly miniProjet1DbContext _db;
        public IEnumerable<Filiere> FL { get; set; }
        public IEnumerable<Professeur> PL { get; set; }
        public AjoutMModel(miniProjet1DbContext db)
        {
            _db = db;
            FL = _db.Filieres.ToList();
            PL = _db.Professeurs.ToList();



        }

        [BindProperty]
        public Matiere Matiere { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Matieres.Add(Matiere);
            await _db.SaveChangesAsync();

            return RedirectToPage("./IndexM");
        }

    }
}
