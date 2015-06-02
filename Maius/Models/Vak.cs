using System;
using Newtonsoft.Json;

namespace Maius
{
	public class Vak
	{
		[JsonProperty(PropertyName="id_vak")]
		public string ID { get; set; }

		[JsonProperty(PropertyName="naam")]
		public string Omschrijving { get; set; }

		public int Rating { get; set; }


		public override string ToString ()
		{
			return string.Format ("[Vak: Omschrijving={0}, ID={1}", Omschrijving, ID);
		}

		public Vak ()
		{
			
		}
	}
}

