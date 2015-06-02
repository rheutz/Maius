﻿using System;
using RestSharp.Portable;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Maius;

namespace Maius
{
	public static class MaiusAPI
	{
		public static async Task Fetch() {
			using (var client = new RestClient ("http://heutsiethuis.no-ip.org/")) {
				var request = new RestRequest ("leerdoelen", HttpMethod.Get);

				var result = await client.Execute (request);

				string resultString = System.Text.Encoding.UTF8.GetString (result.RawBytes, 0, result.RawBytes.Length);
				var leerdoelenlist = JsonConvert.DeserializeObject<Leerdoelen> (resultString);
				MaiusDatabase.GetInstance ().AddLeerdoelenTODB (leerdoelenlist.listLeerdoelen);

				var request2 = new RestRequest ("vakken", HttpMethod.Get);
				result = await client.Execute (request2);

				resultString = System.Text.Encoding.UTF8.GetString (result.RawBytes, 0, result.RawBytes.Length);
				var vakkenlist = JsonConvert.DeserializeObject<Vakken> (resultString);
				MaiusDatabase.GetInstance ().AddVakkenTODB (vakkenlist.listVakken);

			}
		
		}
	}
}

