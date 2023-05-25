using System;
namespace CodeVoyage.Models
{
	public class Itineraire
	{
        public int Id { get; set; }
        public string LieuDepart { get; set; }
        public string Destination { get; set; }
        public double Prix { get; set; }
        public string Place { get; set; }
        public MoyenDeTransport Transport { get; set; }
        public int NombreVoyageur { get; set; }
        public DateTime Depart { get; set; }
        public DateTime Arrivee { get; set; }
    }
}

