using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using miniProjet1.Modele;

namespace miniProjet1.Pages
{
    public class EditPrModel : PageModel
    {
        private readonly miniProjet1DbContext _db;
        public IEnumerable<Seance> SL { get; set; }
        public EditPrModel(miniProjet1DbContext db)
        {
            _db = db;
            SL = _db.Seances.ToList();

        }


        public IActionResult OnGet(int? id)
        {

            Seance seance = _db.Seances.FirstOrDefault(F => F.id_se == id);
            Matiere matiere = _db.Matieres.FirstOrDefault(F => F.id_mat == seance.matiereID);
            Filiere filiere = _db.Filieres.FirstOrDefault(F => F.id_fil == matiere.filiereID);
            foreach (Etudiant etudiant in _db.Etudiants.Where(E => E.filiereID == filiere.id_fil).ToList())
            {
                Presence Presence = new Presence
                {
                    seanceID = seance.id_se,
                    etudiantID = etudiant.id_etu,
                    Pre = "A"
                };
                _db.Presences.Add(Presence);
                _db.SaveChanges();
            }
            return RedirectToPage("./IndexPr");
        }

    }
}