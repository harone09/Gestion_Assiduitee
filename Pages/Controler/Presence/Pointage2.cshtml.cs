using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using miniProjet1.Modele;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace miniProjet1.Pages
{
    public class Pointage2Model : PageModel
    {
        private readonly miniProjet1DbContext _db;
        public IEnumerable<Seance> SL { get; set; }
        public Pointage2Model(miniProjet1DbContext db)
        {
            _db = db;
            SL = _db.Seances.ToList();

        }

        public IList<Seance> Seance { get; set; }
        //public Matiere Fil { get; set; }

        public async Task OnGetAsync()
        {
            Seance = await _db.Seances.ToListAsync();
        }


    }
}