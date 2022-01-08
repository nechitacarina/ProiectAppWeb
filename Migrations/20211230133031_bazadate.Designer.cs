﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nechita_Carina_Proiect.Data;

namespace Nechita_Carina_Proiect.Migrations
{
    [DbContext(typeof(Nechita_Carina_ProiectContext))]
    [Migration("20211230133031_bazadate")]
    partial class bazadate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Card", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContID")
                        .HasColumnType("int");

                    b.Property<int>("PIN")
                        .HasColumnType("int");

                    b.Property<int>("TipCardID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ContID");

                    b.HasIndex("TipCardID");

                    b.ToTable("Card");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TipClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("data_inscrierii")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_nasterii")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ocupatie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TipClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Cont", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("TipContBancarID")
                        .HasColumnType("int");

                    b.Property<DateTime>("data_deschiderii")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("sold")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("TipContBancarID");

                    b.ToTable("Cont");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Imprumut", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContID")
                        .HasColumnType("int");

                    b.Property<int>("TipImprumutID")
                        .HasColumnType("int");

                    b.Property<DateTime>("data_final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_inceput")
                        .HasColumnType("datetime2");

                    b.Property<int>("durata")
                        .HasColumnType("int");

                    b.Property<double>("suma_datorata")
                        .HasColumnType("float");

                    b.Property<double>("suma_imprumutata")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("ContID");

                    b.HasIndex("TipImprumutID");

                    b.ToTable("Imprumut");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.TipCard", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descriere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipCard");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.TipClient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descriere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipClient");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.TipContBancar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descriere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipContBancar");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.TipImprumut", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descriere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipImprumut");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.TipTranzactie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descriere")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TipTranzactie");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Tranzactie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContID")
                        .HasColumnType("int");

                    b.Property<int>("TipTranzactieID")
                        .HasColumnType("int");

                    b.Property<DateTime>("data_tranzactie")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("suma")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.HasIndex("ContID");

                    b.HasIndex("TipTranzactieID");

                    b.ToTable("Tranzactie");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Card", b =>
                {
                    b.HasOne("Nechita_Carina_Proiect.Models.Cont", "Cont")
                        .WithMany("Carduri")
                        .HasForeignKey("ContID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nechita_Carina_Proiect.Models.TipCard", "TipCard")
                        .WithMany("Carduri")
                        .HasForeignKey("TipCardID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cont");

                    b.Navigation("TipCard");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Client", b =>
                {
                    b.HasOne("Nechita_Carina_Proiect.Models.TipClient", "TipClient")
                        .WithMany("Clienti")
                        .HasForeignKey("TipClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipClient");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Cont", b =>
                {
                    b.HasOne("Nechita_Carina_Proiect.Models.Client", "Client")
                        .WithMany("Conturi")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nechita_Carina_Proiect.Models.TipContBancar", "TipContBancar")
                        .WithMany("Conturi")
                        .HasForeignKey("TipContBancarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("TipContBancar");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Imprumut", b =>
                {
                    b.HasOne("Nechita_Carina_Proiect.Models.Cont", "Cont")
                        .WithMany("Imprumuturi")
                        .HasForeignKey("ContID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nechita_Carina_Proiect.Models.TipImprumut", "TipImprumut")
                        .WithMany("Imprumuturi")
                        .HasForeignKey("TipImprumutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cont");

                    b.Navigation("TipImprumut");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Tranzactie", b =>
                {
                    b.HasOne("Nechita_Carina_Proiect.Models.Cont", "Cont")
                        .WithMany("Tranzactii")
                        .HasForeignKey("ContID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nechita_Carina_Proiect.Models.TipTranzactie", "TipTranzactie")
                        .WithMany("Tranzactii")
                        .HasForeignKey("TipTranzactieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cont");

                    b.Navigation("TipTranzactie");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Client", b =>
                {
                    b.Navigation("Conturi");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.Cont", b =>
                {
                    b.Navigation("Carduri");

                    b.Navigation("Imprumuturi");

                    b.Navigation("Tranzactii");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.TipCard", b =>
                {
                    b.Navigation("Carduri");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.TipClient", b =>
                {
                    b.Navigation("Clienti");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.TipContBancar", b =>
                {
                    b.Navigation("Conturi");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.TipImprumut", b =>
                {
                    b.Navigation("Imprumuturi");
                });

            modelBuilder.Entity("Nechita_Carina_Proiect.Models.TipTranzactie", b =>
                {
                    b.Navigation("Tranzactii");
                });
#pragma warning restore 612, 618
        }
    }
}