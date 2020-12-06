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
    public class EditSModel : PageModel
    {

        private readonly miniProjet1DbContext _db;
        public IEnumerable<Matiere> ML { get; set; }
        public EditSModel(miniProjet1DbContext db)
        {
            _db = db;
            ML = _db.Matieres.ToList();



        }

        [BindProperty]
        public Seance Seance { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seance = await _db.Seances.FirstOrDefaultAsync(m => m.id_se == id);

            if (Seance == null)
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

            _db.Attach(Seance).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatiereExists(Seance.id_se))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./IndexS");
        }

        private bool MatiereExists(int id)
        {
            return _db.Seances.Any(e => e.id_se == id);
        }

    }
}