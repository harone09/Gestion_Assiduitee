using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;
namespace miniProjet1.Modele
{
    public class Presence
    {
        [Key]
        public int id_pre { get; set; }

        [Required]
        [Display(Name = "Etudiant")]
        [ForeignKey("Etudiant")]
        public int etudiantID { get; set; }
        public virtual Etudiant etudiant { get; set; }

        [Required]
        [Display(Name = "Seance")]
        [ForeignKey("Seance")]
        public int seanceID { get; set; }
        public virtual Seance seance { get; set; }

        [Required]
        [Display(Name = "Presence")]
        public string Pre { get; set; }









    }
}