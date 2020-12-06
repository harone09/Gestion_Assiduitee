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
    public class AjoutFModel : PageModel
    {
        [BindProperty]
        public Filiere Filiere { get; set; }

        private readonly miniProjet1DbContext _db;

        public AjoutFModel(miniProjet1DbContext db)
        {
            _db = db;

        }


        public IActionResult OnPost(Filiere filiere)
        {
            if (!ModelState.IsValid)
            {
                return Content("error");
            }

            _db.Filieres.Add(filiere);
            _db.SaveChanges();
            return RedirectToPage("/View/Filiere/IndexF");


        }

    }
}