using System;
using Newtonsoft.Json;

namespace Maius
{
	public class Leerdoel
	{
		[JsonProperty(PropertyName="id_leerdoel")]
		public string ID { get; set; }

		[JsonProperty(PropertyName="naam")]
		public string Omschrijving { get; set; }


		public Leerdoel ()
		{
		}

		public override string ToString ()
		{
			return Omschrijving;
		}
	}
}

