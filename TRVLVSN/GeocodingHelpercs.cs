using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TRVLVSN
{
	public class GeocodingHelper
	{
		private static readonly HttpClient client = new HttpClient();

		public static async Task<(double Latitude, double Longitude)?> GetCoordinatesAsync(string address)
		{
			var url = $"https://nominatim.openstreetmap.org/search?q={Uri.EscapeDataString(address)}&format=json&limit=1";
			client.DefaultRequestHeaders.Add("User-Agent", "TravelVisionApp");

			var response = await client.GetAsync(url);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				var jsonResponse = JArray.Parse(content);
				if (jsonResponse.Count > 0)
				{
					var result = jsonResponse[0];
					double latitude = (double)result["lat"];
					double longitude = (double)result["lon"];
					return (latitude, longitude);
				}
			}
			return null;
		}
	}
}
