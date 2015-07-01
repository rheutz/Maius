using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maius
{
	public class Competenties
	{
		[JsonProperty(PropertyName="competenties")]
		public List<Competentie> listCompetenties { get; set;}
	}

	public class Competentie 
	{
		[JsonProperty(PropertyName="id_taakvaardigheid")]
		public string ID { get; set; }

		[JsonProperty(PropertyName="Standaardnaam")]
		public string Omschrijving { get; set; }
	}
}

