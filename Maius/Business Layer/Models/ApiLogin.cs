using System;
using Newtonsoft.Json;

namespace Maius
{
	public class ApiLogin
	{
		[JsonProperty(PropertyName="ERROR")]
		public bool ERROR  { get; set; }

		[JsonProperty(PropertyName="message")]
		public string message { get; set; }

		[JsonProperty(PropertyName="id")]
		public string id { get; set; }

		[JsonProperty(PropertyName="name")]
		public string naam { get; set; }

		[JsonProperty(PropertyName="email")]
		public string email { get; set; }

		[JsonProperty(PropertyName="apiKey")]
		public string apiKey { get; set; }

		[JsonProperty(PropertyName="username")]
		public string username { get; set; }



		public ApiLogin ()
		{
		}
	}
}

