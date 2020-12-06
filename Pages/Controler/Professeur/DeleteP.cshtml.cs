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
    public class DeletePModel : PageModel
    {
        private readonly miniProjet1DbContext _db;

        public DeletePModel(miniProjet1DbContext db)
        {
            _db = db;

        }

        public Professeur Professeur { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Professeur = await _db.Professeurs.FindAsync(id);

            if (Professeur != null)
            {
                _db.Professeurs.Remove(Professeur);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("IndexP");
        }
    }
}
