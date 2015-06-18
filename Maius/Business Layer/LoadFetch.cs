using System;
using RestSharp.Portable;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Maius;
using System.Collections.Generic;

namespace Maius
{
	public static class LoadFetch
	{

		public static async Task<List<Vak>> CallVakken()
		{
			return await MaiusAPI.getVakken ();
		}
		public static async Task<List<Leerdoel>> CallLeerdoelen(string vakID)
		{
			return await MaiusAPI.getLeerdoelenByVakID (vakID);
		}
		public static async Task<List<Competentie>> CallCompetenties(string leerdoelID)
		{
			return await MaiusAPI.getCompetentiesByLeerdoelID (leerdoelID);
		} 
	}
}

