using CodeVoyage.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CodeVoyage.Controllers
{
    public class ItineraireController : Controller
    {
        public IActionResult CreerItineraire()

        {
            return View();
        }

        [HttpPost]
        public IActionResult CreerItineraire(string LieuDepart, String Destination, double Prix, MoyenDeTransport Transport, int NombreVoyageur, DateTime DateDepart, DateTime DateArrivee)
        {


            using (Dal dal = new Dal())
            {
                dal.CreerItineraire(LieuDepart, Destination, Prix, Transport, NombreVoyageur, DateDepart, DateArrivee);


                return RedirectToAction("CreerItineraire");
            }






        }

        public IActionResult ObtientTousLesItineraires()

        {


            using (Dal dal = new Dal())
            {
                dal.ObtientTousLesItineraires();


                return RedirectToAction("ObtientTousLesItineraires");
            }


        }
    }
}
