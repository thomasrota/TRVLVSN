using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRVLVSN
{
	public class Destination
	{
		public string Name { get; set; }
		public DateTime ArrivalDate { get; set; }
		public DateTime DepartureDate { get; set; }
		public List<string> Activities { get; set; }

		public Destination()
		{
			Activities = new List<string>();
		}

		public void AddActivity(string activity)
		{
			Activities.Add(activity);
		}
	}
}
