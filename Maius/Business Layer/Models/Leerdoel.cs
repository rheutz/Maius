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

		[JsonProperty(PropertyName="eigenoordeel")]
		public string Rating { get; set; }

		public override string ToString ()
		{
			return string.Format ("[Leerdoel: Omschrijving={0}, ID={1}, Rating={2}", Omschrijving, ID, Rating);
		}

	}
}

