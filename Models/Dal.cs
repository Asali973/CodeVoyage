﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeVoyage.Models
{
    public class Dal : IDal, IDisposable
    {
        private BddContext _bddContext;
        public Dal()
        {
            _bddContext = new BddContext();
        }

        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }

        // Méthodes OffresVoyage

        public List<OffreVoyage> ObtientToutesLesOffres()
        {
            return _bddContext.OffreVoyages.ToList();
        }

        public int CreerOffresVoyage(Itineraire Itineraire, Evenement Event, Service Service, Service ServiceEx, int Remise, double PrixTotal, double prixAffiche)
        {

            OffreVoyage offre = new OffreVoyage() { Itineraire = Itineraire, Event = Event, Service = Service, ServiceEx = ServiceEx, Remise = Remise, prixTotal = PrixTotal, prixAffiche = prixAffiche };

            _bddContext.OffreVoyages.Add(offre);
            _bddContext.SaveChanges();
            return offre.Id;
        }

        public void ModifierOffreVoyage(int id, Itineraire Itineraire, Evenement Event, Service Service, Service ServiceEx, int Remise, double PrixTotal, double prixAffiche)
        {
            OffreVoyage offre = _bddContext.OffreVoyages.Find(id);

            if (offre != null)
            {
                offre.Itineraire = Itineraire;
                offre.Event = Event;
                offre.Service = Service;
                offre.ServiceEx = ServiceEx;
                offre.Remise = Remise;
                offre.prixTotal = PrixTotal;
                offre.prixAffiche = prixAffiche;
                _bddContext.SaveChanges();
            }

        }

        // Fin méthodes Offre de voyage


        // Méthodes Evenements


        public List<Evenement> ObtientTousLesEvenements()
        {
            return _bddContext.Evenements.ToList();
        }

        public int CreerEvenement(string Nom, DateTime Date, string Localisation, TypeEvenement TypeEvent)
        {

            Evenement evenement = new Evenement() { Nom= Nom, Date= Date,Localisation= Localisation,TypeEvenement= TypeEvent};

            _bddContext.Evenements.Add(evenement);
            _bddContext.SaveChanges();
            return evenement.Id;
        }

        public void ModifierEvenement(int id, string Nom, DateTime Date, string Localisation, TypeEvenement TypeEvent)
        {
           Evenement evenement = _bddContext.Evenements.Find(id);

            if (evenement != null)
            {
                evenement.Nom = Nom;
                evenement.Date = Date;
                evenement.Localisation = Localisation;
                evenement.TypeEvenement = TypeEvent;
          
                _bddContext.SaveChanges();
            }
      
        }

        public void SupprimerEvenement(int id) // A tester
         {
             Evenement evenement = _bddContext.Evenements.Find(id);

            
             if (evenement!=null)
             {

                 _bddContext.Evenements.Remove(evenement);

                 _bddContext.SaveChanges();
             }
         }


        // Méthodes Itineraire


        public List<Itineraire> ObtientTousLesItineraires()
        {
            return _bddContext.Itineraires.ToList();
        }

        public int CreerItineraire(string LieuDepart, String Destination, double Prix, MoyenDeTransport Transport, int NombreVoyageur, DateTime DateDepart, DateTime DateArrivee)
        {

            Itineraire itineraire = new Itineraire() { LieuDepart = LieuDepart, Destination = Destination, Prix = Prix, Transport = Transport, NombreVoyageur= NombreVoyageur,DateDepart= DateDepart,DateArrivee=DateArrivee };

            _bddContext.Itineraires.Add(itineraire);
            _bddContext.SaveChanges();
            return itineraire.Id;
        }

        public void ModifierItineraire(int Id ,string LieuDepart, String Destination, double Prix, MoyenDeTransport Transport, int NombreVoyageur, DateTime DateDepart, DateTime DateArrivee)
        {
            Itineraire itineraire = _bddContext.Itineraires.Find(Id);

            if (itineraire != null)
            {
                itineraire.LieuDepart= LieuDepart;
                itineraire.Destination = Destination;
                itineraire.Prix = Prix;
                itineraire.Transport = Transport;
                itineraire.NombreVoyageur= NombreVoyageur;
                itineraire.DateDepart = DateDepart;
                itineraire.DateArrivee= DateArrivee;
                _bddContext.SaveChanges();
            }

        }

        public void SupprimerItineraire(int id) // A tester
        {
            Itineraire itineraire = _bddContext.Itineraires.Find(id);


            if (itineraire != null)
            {

                _bddContext.Itineraires.Remove(itineraire);

                _bddContext.SaveChanges();
            }
        }
      






        public void Dispose()
        {
            _bddContext.Dispose();
        }
        
    }
}


