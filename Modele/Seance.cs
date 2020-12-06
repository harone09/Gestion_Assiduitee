using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
namespace miniProjet1.Modele
{
    public class Seance
    {
        [Key]
        public int id_se { get; set; }


        [Required(ErrorMessage = "Veuillez fournir une date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy hh:mm}")]
        [Display(Name = "Date")]
        public DateTime dateS { get; set; }

        [Required(ErrorMessage = "Veuillez preciser une matiere")]
        [Display(Name = "Matiere")]
        [ForeignKey("Matiere")]
        public int matiereID { get; set; }
        public virtual Matiere matiere { get; set; }


        [Required(ErrorMessage = "Veuillez preciser une duree")]
        [Display(Name = "Duree")]
        public double duree { get; set; }





    }
}