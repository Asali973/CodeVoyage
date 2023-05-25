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

        public List<OffreVoyage> ObtientToutesLesOffres()
        {
            return _bddContext.OffreVoyages.ToList();
        }

       

        public int CreerOffresVoyage(Itineraire Itineraire, Evenement Event, Service Service, Service ServiceEx, int Remise, double PrixTotal, double prixAffiche) {

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
                offre.prixTotal= PrixTotal;
                offre.prixAffiche = prixAffiche;
                _bddContext.SaveChanges();
            }
      
        }
        public void Dispose()
        {
            _bddContext.Dispose();
        }
    }
}


