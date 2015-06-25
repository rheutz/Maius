using System;
using Newtonsoft.Json;

namespace Maius
{
	public class ApiRegister
	{
		[JsonProperty(PropertyName="ERROR")]
		public bool ERROR  { get; set; }

		[JsonProperty(PropertyName="message")]
		public string message { get; set; }


		public ApiRegister ()
		{
		}
	}
}

