using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maius
{
	public class Leerdoelen
	{
		[JsonProperty(PropertyName="leerdoelen")]
		public List<Leerdoel> listLeerdoelen { get; set;}

		public Leerdoelen ()
		{
		}
	}
}

