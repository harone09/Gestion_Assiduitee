using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miniProjet1.Modele;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace miniProjet1.Pages
{
    public class EditPModel : PageModel
    {
        private readonly miniProjet1DbContext _db;

        public EditPModel(miniProjet1DbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Professeur Professeur { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Professeur = await _db.Professeurs.FirstOrDefaultAsync(m => m.id_prof == id);

            if (Professeur == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Attach(Professeur).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesseurExists(Professeur.id_prof))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./IndexP");
        }

        private bool ProfesseurExists(int id)
        {
            return _db.Professeurs.Any(e => e.id_prof == id);
        }
    }
}
