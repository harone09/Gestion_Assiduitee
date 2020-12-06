using System;
using System.ComponentModel.DataAnnotations;

namespace miniProjet1.Modele
{
    public class Professeur
    {
        [Key]
        public int id_prof { get; set; }

        [Required(ErrorMessage = "Veuillez fournir un nom")]
        [Display(Name = "Nom")]
        public string nom { get; set; }

        [Required(ErrorMessage = "Veuillez fournir un prenom")]
        [Display(Name = "Prenom")]
        public string prenom { get; set; }

        [Required(ErrorMessage = "Veuillez fournir une date de naissance")]
        [DataType(DataType.Date)]
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


        [Required(ErrorMessage = "Veuillez fournir un login")]
        [Display(Name = "Login")]
        public string login { get; set; }

        [Required(ErrorMessage = "Veuillez fournir un mot de passe")]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public string password { get; set; }


    }
}