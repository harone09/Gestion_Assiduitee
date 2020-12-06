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
    public class PointageModel : PageModel
    {
        private readonly miniProjet1DbContext _db;
        [BindProperty]
        public Presence Presence { get; set; }
        public IEnumerable<Seance> SL { get; set; }
        public PointageModel(miniProjet1DbContext db)
        {
            _db = db;
            SL = _db.Seances.ToList();

        }
        public IActionResult OnPost(Presence Presence)
        {
            if (!EtudiantExists(Presence.etudiantID) && !SeanceExists(Presence.seanceID))
            {
                return NotFound();
            }
            else
            {
                _db.Presences.Add(Presence);
                _db.SaveChanges();
                return Page();
            }

        }
        private bool EtudiantExists(int id)
        {
            return _db.Etudiants.Any(e => e.id_etu == id);
        }
        private bool SeanceExists(int id)
        {
            return _db.Seances.Any(e => e.id_se == id);
        }

    }
}