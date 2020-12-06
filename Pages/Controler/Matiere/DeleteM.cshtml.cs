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
    public class DeleteMModel : PageModel
    {
        private readonly miniProjet1DbContext _db;

        public DeleteMModel(miniProjet1DbContext db)
        {
            _db = db;

        }

        public Matiere Matiere { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Matiere = await _db.Matieres.FindAsync(id);

            if (Matiere != null)
            {
                _db.Matieres.Remove(Matiere);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("IndexM");
        }
    }
}
