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
    public class DeleteFModel : PageModel
    {

        private readonly miniProjet1DbContext _db;

        public DeleteFModel(miniProjet1DbContext db)
        {
            _db = db;

        }

        public Filiere Fil { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fil = await _db.Filieres.FindAsync(id);

            if (Fil != null)
            {
                _db.Filieres.Remove(Fil);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("IndexF");
        }
    }
}
