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
    public class AjoutEModel : PageModel
    {

        [BindProperty]
        public Etudiant Etudiant { get; set; }

        private readonly miniProjet1DbContext _db;

        public AjoutEModel(miniProjet1DbContext db)
        {
            _db = db;
            FL = _db.Filieres.ToList();

        }
        public IEnumerable<Filiere> FL { get; set; }

        public IActionResult OnPost(Etudiant etudiant)
        {

            if (!ModelState.IsValid)
            {
                return Content("error");
            }

            _db.Etudiants.Add(etudiant);
            _db.SaveChanges();
            return RedirectToPage("/View/Etudiant/IndexE");
        }

    }

}