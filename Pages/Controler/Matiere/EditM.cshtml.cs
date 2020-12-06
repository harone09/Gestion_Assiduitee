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
    public class EditMModel : PageModel
    {

        private readonly miniProjet1DbContext _db;
        public IEnumerable<Filiere> FL { get; set; }
        public IEnumerable<Professeur> PL { get; set; }
        public EditMModel(miniProjet1DbContext db)
        {
            _db = db;
            FL = _db.Filieres.ToList();
            PL = _db.Professeurs.ToList();



        }

        [BindProperty]
        public Matiere Matiere { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Matiere = await _db.Matieres.FirstOrDefaultAsync(m => m.id_mat == id);

            if (Matiere == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Attach(Matiere).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatiereExists(Matiere.id_mat))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./IndexM");
        }

        private bool MatiereExists(int id)
        {
            return _db.Matieres.Any(e => e.id_mat == id);
        }

    }
}