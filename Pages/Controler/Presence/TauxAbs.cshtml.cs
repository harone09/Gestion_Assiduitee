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
    public class TauxAbsModel : PageModel
    {
        private readonly miniProjet1DbContext _db;
        public IEnumerable<Seance> SL { get; set; }
        public IEnumerable<Etudiant> EL { get; set; }
        public IEnumerable<Presence> PL { get; set; }

        public TauxAbsModel(miniProjet1DbContext db)
        {
            _db = db;
            SL = _db.Seances.Include(n => n.matiere).ToList();
            EL = _db.Etudiants.ToList();
            PL = _db.Presences.Include(n => n.seance).Include(n => n.etudiant).ToList();

        }

        [BindProperty]
        public int Mid { get; set; }

        public IList<TauxAbs> Presence { get; set; }
        //public Matiere Fil { get; set; }

        public void OnGet()
        {
            Presence = new List<TauxAbs>();
            Mid = 1;
            int nbrE = 0;
            int pres = 0;

            foreach (var item in SL)
            {
                if (Mid == item.matiereID)
                {
                    foreach (var item2 in EL)
                    {
                        if (item.matiere.filiereID == item2.filiereID)
                        {
                            foreach (var item3 in PL)
                            {
                                if (item.id_se == item3.seanceID && item2.id_etu == item3.etudiantID)
                                {
                                    pres++;
                                }
                            }
                            nbrE++;
                        }
                    }
                }

            }
            Presence.Add(new TauxAbs()
            {
                etat = "Absent",
                nbr = nbrE - pres

            });
            Presence.Add(new TauxAbs()
            {
                etat = "Present",
                nbr = pres
            });

        }
        public void OnPost(int Mid)
        {
            Presence = new List<TauxAbs>();
            int nbrE = 0;
            int pres = 0;

            foreach (var item in SL)
            {
                if (Mid == item.matiereID)
                {
                    foreach (var item2 in EL)
                    {
                        if (item.matiere.filiereID == item2.filiereID)
                        {
                            foreach (var item3 in PL)
                            {
                                if (item.id_se == item3.seanceID && item2.id_etu == item3.etudiantID)
                                {
                                    pres++;
                                }
                            }
                            nbrE++;
                        }
                    }
                }

            }
            Presence.Add(new TauxAbs()
            {
                etat = "Absent",
                nbr = nbrE - pres

            });
            Presence.Add(new TauxAbs()
            {
                etat = "Present",
                nbr = pres
            });

        }

    }
}