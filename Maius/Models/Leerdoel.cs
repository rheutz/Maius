using System;

namespace Maius
{
	public class Leerdoel
	{
		public string Omschrijving { get; set; }
		public string Rating { get; set; }

		public Leerdoel (string omschrijving, string rating)
		{
			this.Omschrijving = omschrijving;
			this.Rating = rating;
		}

		public override string ToString()
		{
			return string.Format ("{0},{1}", Omschrijving, Rating);
		}
	}
}

