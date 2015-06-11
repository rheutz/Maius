using System;
using System.Threading.Tasks;

namespace Maius
{
	public static class LoadFetch
	{
		public static async Task callFetch ()
		{
			await MaiusAPI.Fetch ();
		}
	}
}

