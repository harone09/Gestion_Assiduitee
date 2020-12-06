using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
namespace miniProjet1.Modele
{
    public class Etudiant
    {


        [Key]
        public int id_etu { get; set; }

        [Required(ErrorMessage = "Veuillez fournir un nom")]
        [Display(Name = "Nom")]
        public string nom { get; set; }

        [Required(ErrorMessage = "Veuillez fournir un prenom")]
        [Display(Name = "Prenom")]
        public string prenom { get; set; }

        [Required(ErrorMessage = "Veuillez fournir une date de naissance")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Date de naissance")]
        public DateTime dateN { get; set; }

        [Required(ErrorMessage = "Veuillez fournir un numero de telephone")]
        [Phone]
        [MinLength(10, ErrorMessage = "numero de telephone invalide")]
        [MaxLength(10, ErrorMessage = "numero de telephone invalide")]
        [Display(Name = "N.Telephone")]
        public string contactT { get; set; }

        [Required(ErrorMessage = "Veuillez fournir un e-mail")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string contactM { get; set; }

        [Required(ErrorMessage = "Veuillez preciser une filiere")]
        [Display(Name = "Filiere")]
        [ForeignKey("Filiere")]
        public int filiereID { get; set; }
        public virtual Filiere filiere { get; set; }

        /*[Required]
        public int code { get; set; }*/



    }
}