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
    public class ListePrModel : PageModel
    {
        private readonly miniProjet1DbContext _db;
        public IEnumerable<Seance> SL { get; set; }
        public IEnumerable<Etudiant> EL { get; set; }
        public ListePrModel(miniProjet1DbContext db)
        {
            _db = db;
            SL = _db.Seances.Include(n => n.matiere).ToList();
            EL = _db.Etudiants.ToList();

        }

        [BindProperty]
        public int Mid { get; set; }

        public IList<Presence> Presence { get; set; }
        //public Matiere Fil { get; set; }

        public async Task OnGetAsync()
        {
            Mid = 1;
            Presence = await _db.Presences.Include(n => n.etudiant).Include(a => a.seance).Where(q => q.seance.matiereID == Mid).ToListAsync();
        }
        public async Task OnPostAsync(int? Mid)
        {

            Presence = await _db.Presences.Include(n => n.etudiant).Include(a => a.seance).Where(q => q.seance.matiereID == Mid).ToListAsync();

        }

    }
}