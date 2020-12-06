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
    public class DeleteEModel : PageModel
    {
        private readonly miniProjet1DbContext _db;

        public DeleteEModel(miniProjet1DbContext db)
        {
            _db = db;

        }

        public Etudiant etudiant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            etudiant = await _db.Etudiants.FindAsync(id);

            if (etudiant != null)
            {
                _db.Etudiants.Remove(etudiant);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("IndexE");
        }
    }
}
