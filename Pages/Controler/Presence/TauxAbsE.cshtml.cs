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
    public class TauxAbsEModel : PageModel
    {
        private readonly miniProjet1DbContext _db;
        public IEnumerable<Seance> SL { get; set; }
        public IEnumerable<Etudiant> EL { get; set; }
        public IEnumerable<Presence> PL { get; set; }
        public IEnumerable<Filiere> FL { get; set; }


        public TauxAbsEModel(miniProjet1DbContext db)
        {
            _db = db;
            SL = _db.Seances.Include(n => n.matiere).ToList();
            EL = _db.Etudiants.Include(n => n.filiere).ToList();
            FL = _db.Filieres.ToList();
            PL = _db.Presences.Include(n => n.seance).Include(n => n.etudiant).ToList();
            Fid = _db.Filieres.FirstOrDefault().id_fil;
            Eid = _db.Etudiants.Where(n => n.filiereID == Fid).FirstOrDefault().id_etu;

        }

        [BindProperty]
        public int Fid { get; set; }
        [BindProperty]
        public int Eid { get; set; }


        public IList<TauxAbs> Presence { get; set; }
        //public Matiere Fil { get; set; }

        public void OnGet()
        {
            Presence = new List<TauxAbs>();
            int nbrS = 0;
            int pres = 0;

            foreach (var item in SL)
            {

                if (Fid == item.matiere.filiereID)
                {
                    nbrS++;
                    foreach (var item2 in PL)
                    {
                        if (item.id_se == item2.seanceID && item2.etudiantID == Eid)
                        {
                            pres++;
                        }

                    }

                }

            }
            Presence.Add(new TauxAbs()
            {
                etat = "Absent",
                nbr = nbrS - pres

            });
            Presence.Add(new TauxAbs()
            {
                etat = "Present",
                nbr = pres
            });

        }
        public void OnPost(int Fid, int Eid)
        {
            Presence = new List<TauxAbs>();
            int nbrS = 0;
            int pres = 0;

            foreach (var item in SL)
            {

                if (Fid == item.matiere.filiereID)
                {
                    nbrS++;
                    foreach (var item2 in PL)
                    {
                        if (item.id_se == item2.seanceID && item2.etudiantID == Eid)
                        {
                            pres++;
                        }

                    }

                }

            }
            Presence.Add(new TauxAbs()
            {
                etat = "Absent",
                nbr = nbrS - pres

            });
            Presence.Add(new TauxAbs()
            {
                etat = "Present",
                nbr = pres
            });


        }

    }
}