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
    public class IndexPModel : PageModel
    {
        private readonly miniProjet1DbContext _db;

        public IndexPModel(miniProjet1DbContext db)
        {
            _db = db;
        }

        public IList<Professeur> Professeur { get; set; }

        public async Task OnGetAsync()
        {
            Professeur = await _db.Professeurs.ToListAsync();
        }
    }
}
