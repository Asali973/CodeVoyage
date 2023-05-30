using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeVoyage.Models
{
	
        public class BddContext : DbContext
        {
            public DbSet<Evenement> Evenements { get; set; }
            //public DbSet<Catalogue> Catalogues{ get; set; }
            public DbSet<Itineraire> Itineraires { get; set; }
            public DbSet<Membre> Membres { get; set; }
            public DbSet<OffreVoyage> OffreVoyages { get; set; }
            public DbSet<Partenaire> Partenaires { get; set; }
            public DbSet<Reservation> Reservations { get; set; }
            public DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=MMMMM;database=CodeVoyageBDD");
            }

        public void InitializeDb()
        {
<<<<<<< HEAD
           this.Database.EnsureDeleted();
=======
            this.Database.EnsureDeleted();
>>>>>>> f04a4c7b0412c7c5eef793eea701372a99a7dcf0
            this.Database.EnsureCreated();
            this.Evenements.AddRange(
                new Evenement
                {
                    Id = 1,
                    Nom = "Carnaval de Rio",
                    Date = new DateTime(2024, 02, 09),
                    Localisation = "Rio",
                    TypeEvenement = ((TypeEvenement)3)
                },
                new Evenement
                {
                    Id = 2,
                    Nom = "Caribana festival",
                    Date = new DateTime(2023, 07, 01),
                    Localisation = "Toronto",
                    TypeEvenement = ((TypeEvenement)3)

                },
                new Evenement
                {
                    Id = 3,
                    Nom = "Atlanta Arts",
                    Date = new DateTime(2023, 09, 01),
                    Localisation = "Piedmont Park",
                    TypeEvenement = ((TypeEvenement)1)

                },
                new Evenement
                {
                    Id = 4,
                    Nom = "San Francisco Fall Antiques Show",
                    Date = new DateTime(2023, 10, 01),
                    Localisation = "San Francisco",
                    TypeEvenement = ((TypeEvenement)1)

                }

                );
                this.Itineraires.AddRange(
                new Itineraire
                {
                    Id = 1,
                    DateDepart = new DateTime(2024, 02, 07),
                    DateArrivee = new DateTime(2024, 02, 21),
                    LieuDepart = "Paris",
                    Destination = "Rio De Janeiro",
                    NombreVoyageur = 40,
                    Transport = ((MoyenDeTransport)0),
                    Prix = 560
                },
                new Itineraire
                {
                    Id = 2,
                    DateDepart = new DateTime(2023, 06, 30),
                    DateArrivee = new DateTime(2023, 07, 14),
                    LieuDepart = "Paris",
                    Destination = "Toronto",
                    NombreVoyageur = 50,
                    Transport = ((MoyenDeTransport)0),
                    Prix = 575
                },
                new Itineraire
                {
                    Id = 3,
                    DateDepart = new DateTime(2023, 10, 15),
                    DateArrivee = new DateTime(2023, 11, 01),
                    LieuDepart = "Paris",
                    Destination = "San Francisco",
                    NombreVoyageur = 30,
                    Transport = ((MoyenDeTransport)0),
                    Prix = 560
                });

            this.Services.AddRange(
                new Service
                {
                    Id = 1,
<<<<<<< HEAD
                    nomService= "Visite du Corcovado",
                    Capacite= 20,
                    DateDeb= new DateTime(2023, 10, 21),
                    DateFin= new DateTime(2024, 12, 20),
=======
                    nomService= "Visite touristique",
                    Capacite= 20,
                    Date= new DateTime(2023, 10, 21),
>>>>>>> f04a4c7b0412c7c5eef793eea701372a99a7dcf0
                    TypeService=((TypeService)4),
                    Prix = 10
                },
                new Service
                {
                    Id = 2,
                    nomService = "Mini golf",
                    Capacite = 9,
<<<<<<< HEAD
                    DateDeb = new DateTime(2023, 07, 01),
                    DateFin = new DateTime(2023, 09, 03),
=======
                    Date = new DateTime(2023, 07, 21),
>>>>>>> f04a4c7b0412c7c5eef793eea701372a99a7dcf0
                    TypeService = ((TypeService)2),
                    Prix = 12
                },
                new Service
                {
                    Id = 3,
<<<<<<< HEAD
                    nomService = "Location de limousine à l'heure",
                    Capacite = 2,
                    DateDeb = new DateTime(2023, 06, 01),
                    DateFin = new DateTime(2024, 06, 01),
                    TypeService = ((TypeService)1),
                    Prix = 200
=======
                    nomService = "Airbnb",
                    Capacite = 2,
                    Date = new DateTime(2023, 08, 21),
                    TypeService = ((TypeService)1),
                    Prix = 140
>>>>>>> f04a4c7b0412c7c5eef793eea701372a99a7dcf0
                });;


            this.SaveChanges();
        }

    }
    
}

