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
    public class IndexEModel : PageModel
    {
        private readonly miniProjet1DbContext _db;

        public IndexEModel(miniProjet1DbContext db)
        {
            _db = db;
            FL = _db.Filieres.ToList();
        }

        public IList<Etudiant> Etudiant { get; set; }
        public IEnumerable<Filiere> FL { get; set; }
        public async Task OnGetAsync()
        {
            Etudiant = await _db.Etudiants.ToListAsync();
        }
    }
}
