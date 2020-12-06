using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace miniProjet1.Migrations
{
    public partial class EMSIDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filieres",
                columns: table => new
                {
                    id_fil = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nom = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filieres", x => x.id_fil);
                });

            migrationBuilder.CreateTable(
                name: "Professeurs",
                columns: table => new
                {
                    id_prof = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nom = table.Column<string>(nullable: false),
                    prenom = table.Column<string>(nullable: false),
                    dateN = table.Column<DateTime>(nullable: false),
                    contactT = table.Column<string>(maxLength: 10, nullable: false),
                    contactM = table.Column<string>(nullable: false),
                    login = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professeurs", x => x.id_prof);
                });

            migrationBuilder.CreateTable(
                name: "Etudiants",
                columns: table => new
                {
                    id_etu = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nom = table.Column<string>(nullable: false),
                    prenom = table.Column<string>(nullable: false),
                    dateN = table.Column<DateTime>(nullable: false),
                    contactT = table.Column<string>(maxLength: 10, nullable: false),
                    contactM = table.Column<string>(nullable: false),
                    filiereID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudiants", x => x.id_etu);
                    table.ForeignKey(
                        name: "FK_Etudiants_Filieres_filiereID",
                        column: x => x.filiereID,
                        principalTable: "Filieres",
                        principalColumn: "id_fil",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matieres",
                columns: table => new
                {
                    id_mat = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nom = table.Column<string>(nullable: false),
                    professeurID = table.Column<int>(nullable: false),
                    filiereID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matieres", x => x.id_mat);
                    table.ForeignKey(
                        name: "FK_Matieres_Filieres_filiereID",
                        column: x => x.filiereID,
                        principalTable: "Filieres",
                        principalColumn: "id_fil",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matieres_Professeurs_professeurID",
                        column: x => x.professeurID,
                        principalTable: "Professeurs",
                        principalColumn: "id_prof",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seances",
                columns: table => new
                {
                    id_se = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dateS = table.Column<DateTime>(nullable: false),
                    matiereID = table.Column<int>(nullable: false),
                    duree = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seances", x => x.id_se);
                    table.ForeignKey(
                        name: "FK_Seances_Matieres_matiereID",
                        column: x => x.matiereID,
                        principalTable: "Matieres",
                        principalColumn: "id_mat",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presences",
                columns: table => new
                {
                    id_pre = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    etudiantID = table.Column<int>(nullable: false),
                    seanceID = table.Column<int>(nullable: false),
                    Pre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presences", x => x.id_pre);
                    table.ForeignKey(
                        name: "FK_Presences_Etudiants_etudiantID",
                        column: x => x.etudiantID,
                        principalTable: "Etudiants",
                        principalColumn: "id_etu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presences_Seances_seanceID",
                        column: x => x.seanceID,
                        principalTable: "Seances",
                        principalColumn: "id_se",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Etudiants_filiereID",
                table: "Etudiants",
                column: "filiereID");

            migrationBuilder.CreateIndex(
                name: "IX_Matieres_filiereID",
                table: "Matieres",
                column: "filiereID");

            migrationBuilder.CreateIndex(
                name: "IX_Matieres_professeurID",
                table: "Matieres",
                column: "professeurID");

            migrationBuilder.CreateIndex(
                name: "IX_Presences_etudiantID",
                table: "Presences",
                column: "etudiantID");

            migrationBuilder.CreateIndex(
                name: "IX_Presences_seanceID",
                table: "Presences",
                column: "seanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Seances_matiereID",
                table: "Seances",
                column: "matiereID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presences");

            migrationBuilder.DropTable(
                name: "Etudiants");

            migrationBuilder.DropTable(
                name: "Seances");

            migrationBuilder.DropTable(
                name: "Matieres");

            migrationBuilder.DropTable(
                name: "Filieres");

            migrationBuilder.DropTable(
                name: "Professeurs");
        }
    }
}
