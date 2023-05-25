using System;
namespace CodeVoyage.Models
{
	public class Evenement
	{
        public int Id { get; set; }
        public string Nom{ get; set; }
        public DateTime Date { get; set; }
        public string Localisation{ get; set; }
        public TypeEvenement TypeEvenement { get; set; }
    }
}

