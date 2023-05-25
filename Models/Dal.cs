using System;
using System.Collections.Generic;
using System.Linq;

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

        //Fin Méthodes Evenements


        public void Dispose()
        {
            _bddContext.Dispose();
        }
        
    }
}


