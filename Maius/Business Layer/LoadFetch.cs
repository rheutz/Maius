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
		public static async Task<ApiLogin> login(string username, string password)
		{
			return await MaiusAPI.login (username, password);
		} 
		public static async Task<Object> storeRating(int rating, string leerdoelid, string instellingid )
		{
			return await MaiusAPI.storeRating (rating, leerdoelid, instellingid);
		}
	}
}

