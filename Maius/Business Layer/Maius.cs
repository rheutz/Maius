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

		protected override async void OnStart ()
		{
			// Handle when your app starts
			// transfer data MaiusAPI to local database
			//await MaiusAPI.Fetch();

		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

