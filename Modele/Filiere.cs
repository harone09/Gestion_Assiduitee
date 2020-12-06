using System;
using System.ComponentModel.DataAnnotations;
namespace miniProjet1.Modele
{
    public class Filiere
    {
        [Key]
        public int id_fil { get; set; }

        [Required(ErrorMessage = "Veuillez fournir un nom")]
        [Display(Name = "Nom")]
        public string nom { get; set; }

    }
}