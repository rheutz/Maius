﻿using System;
using RestSharp.Portable;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Maius;
using System.Collections.Generic;

namespace Maius
{
	public static class MaiusAPI
	{
		static string ApiKey = null;			//apikey voor het uitvoeren van requests
		static string studentid = null;			//studentid


		//Inloggen op de webserver, indien de username en password correct zijn word er een API key terug gegeven
		public static async Task<ApiLogin> login(string username, string password){
			using (var client = new RestClient("http://maiustest.ddns.net/v1/"))
			{
				var request = new RestRequest("login", HttpMethod.Post);
				//add parameters
				request.AddParameter ("username", username);
				request.AddParameter ("password", password);

				//execute the request
				var result = await client.Execute(request);
				string resultString = System.Text.Encoding.UTF8.GetString (result.RawBytes, 0, result.RawBytes.Length);
				var loginResult = JsonConvert.DeserializeObject<ApiLogin> (resultString);

				//store the api key and userid
				ApiKey = loginResult.apiKey;
				studentid = loginResult.id;

				return loginResult;
			}

		}

		//methode voor het ophalen van de vakken via de webservice
		public static async Task<List<Vak>> getVakken(){
			using (var client = new RestClient ("http://maiustest.ddns.net/v1/")) {
				var request = new RestRequest ("vakken", HttpMethod.Get);

				//add api key to header header
				request.AddHeader("Authorization", ApiKey);

				var result = await client.Execute (request);

				string resultString = System.Text.Encoding.UTF8.GetString (result.RawBytes, 0, result.RawBytes.Length);
				var vakkenlist = JsonConvert.DeserializeObject<Vakken> (resultString);

				return vakkenlist.listVakken;
			}
		}

		//methode voor het ophalen van alle leerdoelen behorend bij een vak
		public static async Task<List<Leerdoel>> getLeerdoelenByVakID(string id){
			using (var client = new RestClient ("http://maiustest.ddns.net/v1/")) {
				var request = new RestRequest ("leerdoelen/" + id + "/" + studentid, HttpMethod.Get);

				//add api key to header
				request.AddHeader("Authorization", ApiKey);

				var result = await client.Execute (request);

				string resultString = System.Text.Encoding.UTF8.GetString (result.RawBytes, 0, result.RawBytes.Length);
				var leerdoelenlist = JsonConvert.DeserializeObject<Leerdoelen> (resultString);

				return leerdoelenlist.listLeerdoelen;
		}
	}

		//methode voor het ophalen van de competenties behorend bij een leerdoel
		public static async Task<List<Competentie>> getCompetentiesByLeerdoelID(string id){
			using (var client = new RestClient ("http://maiustest.ddns.net/v1/")) {
				var request = new RestRequest ("competenties/" + id, HttpMethod.Get);


				//add api key to header
				request.AddHeader("Authorization", ApiKey);

				var result = await client.Execute (request);

				string resultString = System.Text.Encoding.UTF8.GetString (result.RawBytes, 0, result.RawBytes.Length);
				var competentiesList = JsonConvert.DeserializeObject<Competenties> (resultString);

				return competentiesList.listCompetenties;
			}
		}

		//methode voor het opslaan van de rating bij een leerdoel
		public static async Task<Object> storeRating(int rating, string leerdoelid, string instellingid ){
			using (var client = new RestClient ("http://maiustest.ddns.net/v1/")) {
				var request = new RestRequest ("leerdoelen/rating", HttpMethod.Post);

				//add parameters
				request.AddParameter ("studentid", studentid);
				request.AddParameter ("leerdoelid", leerdoelid);
				request.AddParameter ("instellingid", instellingid);
				request.AddParameter ("rating", rating);

				//add api key to header
				request.AddHeader("Authorization", ApiKey);

				var result = await client.Execute (request);

				string resultString = System.Text.Encoding.UTF8.GetString (result.RawBytes, 0, result.RawBytes.Length);

				return resultString;
			}
		}
	}
}




