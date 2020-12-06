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
    public class IndexSModel : PageModel
    {
        private readonly miniProjet1DbContext _db;
        public IEnumerable<Matiere> ML { get; set; }
        public IndexSModel(miniProjet1DbContext db)
        {
            _db = db;
            ML = _db.Matieres.ToList();

        }

        public IList<Seance> Seance { get; set; }
        //public Matiere Fil { get; set; }

        public async Task OnGetAsync()
        {
            Seance = await _db.Seances.ToListAsync();
        }


    }
}
