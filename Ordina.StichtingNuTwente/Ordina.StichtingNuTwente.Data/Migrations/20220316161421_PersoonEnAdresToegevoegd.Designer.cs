﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ordina.StichtingNuTwente.Data;

#nullable disable

namespace Ordina.StichtingNuTwente.Data.Migrations
{
    [DbContext(typeof(NuTwenteContext))]
    [Migration("20220316161421_PersoonEnAdresToegevoegd")]
    partial class PersoonEnAdresToegevoegd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Adres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Woonplaats")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("fkReactieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("fkReactieId");

                    b.ToTable("Adres");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Antwoord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("IdVanVraag")
                        .HasColumnType("int");

                    b.Property<int?>("ReactieId")
                        .HasColumnType("int");

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReactieId");

                    b.ToTable("Antwoorden");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Gastgezin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Gastgezinnen");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Persoon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeboorteDatum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Geboorteplaats")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobiel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationaliteit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Talen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefoonnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("fkAdresId")
                        .HasColumnType("int");

                    b.Property<int?>("fkReactieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("fkAdresId");

                    b.HasIndex("fkReactieId");

                    b.ToTable("Persoon");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Reactie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatumIngevuld")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormulierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reacties");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Vrijwilliger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GastgezinId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GastgezinId");

                    b.ToTable("Vrijwilligers");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Adres", b =>
                {
                    b.HasOne("Ordina.StichtingNuTwente.Models.Models.Reactie", "Reactie")
                        .WithMany()
                        .HasForeignKey("fkReactieId");

                    b.Navigation("Reactie");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Antwoord", b =>
                {
                    b.HasOne("Ordina.StichtingNuTwente.Models.Models.Reactie", "Reactie")
                        .WithMany("Antwoorden")
                        .HasForeignKey("ReactieId");

                    b.Navigation("Reactie");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Persoon", b =>
                {
                    b.HasOne("Ordina.StichtingNuTwente.Models.Models.Adres", "Adres")
                        .WithMany()
                        .HasForeignKey("fkAdresId");

                    b.HasOne("Ordina.StichtingNuTwente.Models.Models.Reactie", "Reactie")
                        .WithMany()
                        .HasForeignKey("fkReactieId");

                    b.Navigation("Adres");

                    b.Navigation("Reactie");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Vrijwilliger", b =>
                {
                    b.HasOne("Ordina.StichtingNuTwente.Models.Models.Gastgezin", null)
                        .WithMany("Vrijwilligers")
                        .HasForeignKey("GastgezinId");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Gastgezin", b =>
                {
                    b.Navigation("Vrijwilligers");
                });

            modelBuilder.Entity("Ordina.StichtingNuTwente.Models.Models.Reactie", b =>
                {
                    b.Navigation("Antwoorden");
                });
#pragma warning restore 612, 618
        }
    }
}
