using System;

using Xamarin.Forms;
using System.Threading.Tasks;



namespace Maius
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			//MainPage = new NavigationPage(new VakOverzicht());
			MainPage = new NavigationPage(new LoginPage());
		}
	}
}

