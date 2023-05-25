using System;
namespace CodeVoyage.Models
{
	public class Service
	{
		public TypeService TypeService { get; set; }
        public int Capacite { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Prix { get; set; }

    }
}

