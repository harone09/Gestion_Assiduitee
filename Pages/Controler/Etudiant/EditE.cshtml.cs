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
    public class EditEModel : PageModel
    {
        [BindProperty]
        public Etudiant Etudiant { get; set; }
        public IEnumerable<Filiere> FL { get; set; }
        private readonly miniProjet1DbContext _db;

        public EditEModel(miniProjet1DbContext db)
        {
            _db = db;
            FL = _db.Filieres.ToList();

        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _db.Etudiants.FirstOrDefaultAsync(m => m.id_etu == id);

            if (Etudiant == null)
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

            _db.Attach(Etudiant).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EtudiantExists(Etudiant.id_etu))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./IndexE");
        }

        private bool EtudiantExists(int id)
        {
            return _db.Etudiants.Any(e => e.id_etu == id);
        }

    }
}
