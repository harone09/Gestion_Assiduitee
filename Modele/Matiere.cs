using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
namespace miniProjet1.Modele
{
    public class Matiere
    {
        [Key]
        public int id_mat { get; set; }

        [Required(ErrorMessage = "Veuillez fournir un nom")]
        [Display(Name = "Nom")]
        public string nom { get; set; }

        [Required(ErrorMessage = "Veuillez preciser un professeur")]
        [Display(Name = "Professeur")]
        [ForeignKey("Professeur")]
        public int professeurID { get; set; }
        public virtual Professeur professeur { get; set; }


        [Required(ErrorMessage = "Veuillez preciser une filiere")]
        [Display(Name = "filiere")]
        [ForeignKey("Filiere")]
        public int filiereID { get; set; }
        public virtual Filiere filiere { get; set; }





    }
}