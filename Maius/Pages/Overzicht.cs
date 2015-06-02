using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace Maius
{
	public class Overzicht : ContentPage
	{
		public Overzicht ()
		{
			var listView = new ListView {
				ItemTemplate = new DataTemplate (typeof(LeerdoelCell)),
				HasUnevenRows = true,
				//ItemsSource = MaiusDatabase.GetInstance().getLeerdoelen(),
				ItemsSource = MaiusDatabase.GetInstance().getVakken(),
			};
				
			Content = new StackLayout { 
				Padding = 10,
				Children = {
					listView
				}
			};

			listView.ItemTapped += async (object sender, ItemTappedEventArgs e) => 
			{
				//Leerdoel selected = (Leerdoel)listView.SelectedItem;
				//var leerdoelPage = new LeerdoelPage(selected);
				//await Navigation.PushAsync(leerdoelPage);

			};
	
		}



		protected override void OnAppearing()
		{
			//base.OnAppearing ();
			//fill local database with data from API
			//MaiusAPI.Fetch ();
			//Task.Delay (5000);
		}
						
	}
}


