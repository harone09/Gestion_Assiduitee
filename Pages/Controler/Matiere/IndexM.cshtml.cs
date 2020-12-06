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
    public class IndexMModel : PageModel
    {
        private readonly miniProjet1DbContext _db;
        public IEnumerable<Filiere> FL { get; set; }
        public IEnumerable<Professeur> PL { get; set; }
        public IndexMModel(miniProjet1DbContext db)
        {
            _db = db;
            FL = _db.Filieres.ToList();
            PL = _db.Professeurs.ToList();

        }

        public IList<Matiere> Matiere { get; set; }
        //public Matiere Fil { get; set; }

        public async Task OnGetAsync()
        {
            Matiere = await _db.Matieres.Include(m => m.filiere).Include(m => m.professeur).ToListAsync();
        }


    }
}
