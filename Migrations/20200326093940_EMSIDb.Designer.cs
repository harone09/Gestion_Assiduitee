﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using miniProjet1.Modele;

namespace miniProjet1.Migrations
{
    [DbContext(typeof(miniProjet1DbContext))]
    [Migration("20200326093940_EMSIDb")]
    partial class EMSIDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("miniProjet1.Modele.Etudiant", b =>
                {
                    b.Property<int>("id_etu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("contactM")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("contactT")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<DateTime>("dateN")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("filiereID")
                        .HasColumnType("int");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id_etu");

                    b.HasIndex("filiereID");

                    b.ToTable("Etudiants");
                });

            modelBuilder.Entity("miniProjet1.Modele.Filiere", b =>
                {
                    b.Property<int>("id_fil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id_fil");

                    b.ToTable("Filieres");
                });

            modelBuilder.Entity("miniProjet1.Modele.Matiere", b =>
                {
                    b.Property<int>("id_mat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("filiereID")
                        .HasColumnType("int");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("professeurID")
                        .HasColumnType("int");

                    b.HasKey("id_mat");

                    b.HasIndex("filiereID");

                    b.HasIndex("professeurID");

                    b.ToTable("Matieres");
                });

            modelBuilder.Entity("miniProjet1.Modele.Presence", b =>
                {
                    b.Property<int>("id_pre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Pre")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("etudiantID")
                        .HasColumnType("int");

                    b.Property<int>("seanceID")
                        .HasColumnType("int");

                    b.HasKey("id_pre");

                    b.HasIndex("etudiantID");

                    b.HasIndex("seanceID");

                    b.ToTable("Presences");
                });

            modelBuilder.Entity("miniProjet1.Modele.Professeur", b =>
                {
                    b.Property<int>("id_prof")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("contactM")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("contactT")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<DateTime>("dateN")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("id_prof");

                    b.ToTable("Professeurs");
                });

            modelBuilder.Entity("miniProjet1.Modele.Seance", b =>
                {
                    b.Property<int>("id_se")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("dateS")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("duree")
                        .HasColumnType("double");

                    b.Property<int>("matiereID")
                        .HasColumnType("int");

                    b.HasKey("id_se");

                    b.HasIndex("matiereID");

                    b.ToTable("Seances");
                });

            modelBuilder.Entity("miniProjet1.Modele.Etudiant", b =>
                {
                    b.HasOne("miniProjet1.Modele.Filiere", "filiere")
                        .WithMany()
                        .HasForeignKey("filiereID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("miniProjet1.Modele.Matiere", b =>
                {
                    b.HasOne("miniProjet1.Modele.Filiere", "filiere")
                        .WithMany()
                        .HasForeignKey("filiereID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("miniProjet1.Modele.Professeur", "professeur")
                        .WithMany()
                        .HasForeignKey("professeurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("miniProjet1.Modele.Presence", b =>
                {
                    b.HasOne("miniProjet1.Modele.Etudiant", "etudiant")
                        .WithMany()
                        .HasForeignKey("etudiantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("miniProjet1.Modele.Seance", "seance")
                        .WithMany()
                        .HasForeignKey("seanceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("miniProjet1.Modele.Seance", b =>
                {
                    b.HasOne("miniProjet1.Modele.Matiere", "matiere")
                        .WithMany()
                        .HasForeignKey("matiereID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
