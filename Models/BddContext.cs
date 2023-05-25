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
            optionsBuilder.UseMySql("server=localhost;user id=root;password=Kuroikage@25;database=CodeVoyageBDD");
            }

        }
    
}

