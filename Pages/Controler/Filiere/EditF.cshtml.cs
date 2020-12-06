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
    public class EditFModel : PageModel
    {

        private readonly miniProjet1DbContext _db;

        public EditFModel(miniProjet1DbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Filiere Filiere { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Filiere = await _db.Filieres.FirstOrDefaultAsync(m => m.id_fil == id);

            if (Filiere == null)
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

            _db.Attach(Filiere).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FiliereExists(Filiere.id_fil))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./IndexF");
        }

        private bool FiliereExists(int id)
        {
            return _db.Filieres.Any(e => e.id_fil == id);
        }

    }
}