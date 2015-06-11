using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Maius
{
	public class Vakken
	{
		[JsonProperty(PropertyName="vakken")]
		public List<Vak> listVakken { get; set;}

		public Vakken ()
		{
		}
	}
}

