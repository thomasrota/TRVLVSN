using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVLVSN
{
	public class Trip
	{
		public string TripName { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public List<Destination> Destinations { get; set; }

		public Trip()
		{
			Destinations = new List<Destination>();
		}

		public void AddDestination(Destination destination)
		{
			Destinations.Add(destination);
		}
	}
}
