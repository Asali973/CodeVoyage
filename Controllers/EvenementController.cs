using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeVoyage.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeVoyage.Controllers
{
    public class EvenementController : Controller
    {
        // GET: /<controller>/
        public IActionResult CreerEvenement()
        {

            return View();
          
        }

        [HttpPost]
        public IActionResult CreerEvenement(string Nom, DateTime Date, string Localisation, TypeEvenement TypeEvent)
        {
             
           
                using (Dal dal = new Dal())
                {
                    dal.CreerEvenement(Nom, Date, Localisation,TypeEvent);
                    return RedirectToAction("CreerEvenement");
                }
            
            
        }
<<<<<<< HEAD

        
        public IActionResult SupprimerEvenement(int id)

        {
            using (Dal dal = new Dal())
            {
                dal.SupprimerEvenement(id);
                return RedirectToAction("SupprimerEvenement");

            }
        }
    
=======
>>>>>>> f04a4c7b0412c7c5eef793eea701372a99a7dcf0
    }
}
