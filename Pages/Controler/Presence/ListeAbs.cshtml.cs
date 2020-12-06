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
    public class ListeAbsModel : PageModel
    {
        private readonly miniProjet1DbContext _db;
        public IEnumerable<Seance> SL { get; set; }
        public IEnumerable<Etudiant> EL { get; set; }
        public IEnumerable<Presence> PL { get; set; }

        public ListeAbsModel(miniProjet1DbContext db)
        {
            _db = db;
            SL = _db.Seances.Include(n => n.matiere).ToList();
            EL = _db.Etudiants.ToList();
            PL = _db.Presences.Include(n => n.seance).Include(n => n.etudiant).ToList();

        }

        [BindProperty]
        public int Mid { get; set; }

        public IList<Presence> Presence { get; set; }
        //public Matiere Fil { get; set; }

        public void OnGet()
        {
            Presence = new List<Presence>();
            Mid = 1;
            int abs;
            foreach (var item in SL)
            {
                if (Mid == item.matiereID)
                {
                    foreach (var item2 in EL)
                    {
                        abs = 1;
                        if (item.matiere.filiereID == item2.filiereID)
                        {
                            foreach (var item3 in PL)
                            {
                                if (item.id_se == item3.seanceID && item2.id_etu == item3.etudiantID)
                                {
                                    abs = 0;
                                }
                            }
                            if (abs == 1)
                            {
                                Presence.Add(new Presence()
                                {
                                    etudiantID = item2.id_etu,
                                    seanceID = item.id_se,
                                    Pre = "A",
                                    etudiant = item2
                                });
                            }
                        }
                    }
                }

            }

        }
        public void OnPost(int Mid)
        {
            Presence = new List<Presence>();
            int abs;
            foreach (var item in SL)
            {
                if (Mid == item.matiereID)
                {
                    foreach (var item2 in EL)
                    {
                        abs = 1;
                        if (item.matiere.filiereID == item2.filiereID)
                        {
                            foreach (var item3 in PL)
                            {
                                if (item.id_se == item3.seanceID && item2.id_etu == item3.etudiantID)
                                {
                                    abs = 0;
                                }
                            }
                            if (abs == 1)
                            {
                                Presence.Add(new Presence()
                                {
                                    etudiantID = item2.id_etu,
                                    seanceID = item.id_se,
                                    Pre = "A",
                                    etudiant = item2
                                });
                            }
                        }
                    }
                }

            }

        }

    }
}