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
    public class IndexFModel : PageModel
    {
        private readonly miniProjet1DbContext _db;

        public IndexFModel(miniProjet1DbContext db)
        {
            _db = db;

        }

        public IList<Filiere> Filiere { get; set; }
        //public Filiere Fil { get; set; }

        public async Task OnGetAsync()
        {
            Filiere = await _db.Filieres.ToListAsync();
        }


    }
}
