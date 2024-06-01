using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TRVLVSN
{
	public static class JsonHelper
	{
		public static void SaveToFile<T>(string filePath, List<T> data)
		{
			var json = JsonConvert.SerializeObject(data, Formatting.Indented);
			File.WriteAllText(filePath, json);
		}

		public static List<T> LoadFromFile<T>(string filePath)
		{
			if (!File.Exists(filePath))
				return new List<T>();

			var json = File.ReadAllText(filePath);
			return JsonConvert.DeserializeObject<List<T>>(json);
		}
	}
}
