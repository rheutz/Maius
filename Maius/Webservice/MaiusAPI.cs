using System;
using RestSharp.Portable;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace Maius
{
	public static class MaiusAPI
	{
		public static async Task<Leerdoelen> Fetch() {
			var client = new RestClient ("http://heutsiethuis.no-ip.org/");
			var request = new RestRequest ("leerdoelen", HttpMethod.Get);

			var result = await client.Execute (request);

			string resultString = System.Text.Encoding.UTF8.GetString (result.RawBytes, 0, result.RawBytes.Length);
			var leerdoelenlist = JsonConvert.DeserializeObject<Leerdoelen> (resultString);

			return leerdoelenlist;

		}
	}
}

