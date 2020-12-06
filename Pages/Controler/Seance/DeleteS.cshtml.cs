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
    public class DeleteSModel : PageModel
    {
        private readonly miniProjet1DbContext _db;

        public DeleteSModel(miniProjet1DbContext db)
        {
            _db = db;

        }

        public Seance Seance { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seance = await _db.Seances.FindAsync(id);

            if (Seance != null)
            {
                _db.Seances.Remove(Seance);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("IndexS");
        }
    }
}
