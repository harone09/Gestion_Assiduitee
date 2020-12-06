using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
namespace miniProjet1.Modele
{
    public class miniProjet1DbContext : DbContext
    {

        public miniProjet1DbContext(DbContextOptions<miniProjet1DbContext> options) : base(options)
        {

        }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
        public DbSet<Seance> Seances { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<Presence> Presences { get; set; }



    }
}