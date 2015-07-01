using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Maius
{
	public class VakOverzicht : ContentPage
	{
		public VakOverzicht (List<Vak> vakken)
		{
			Title = " Kies vak";

			var loadingIndicator = new ActivityIndicator (){ 
				Color = Color.Black,
				IsRunning = true,
				IsEnabled = true,
				BindingContext = this,
			};

			var listView = new ListView {
				ItemTemplate = new DataTemplate (typeof(VakCell)),
				HasUnevenRows = true,
				ItemsSource = vakken,
			};
				
			Content = new StackLayout { 
				Padding = 10,
				Children = {
					listView
				}
			};

			listView.ItemTapped += async (object sender, ItemTappedEventArgs e) => 
			{
				this.IsBusy = true;
				Vak selected = (Vak)listView.SelectedItem;
				var leerdoelenOverzicht = new LeerdoelenOverzicht(await LoadFetch.CallLeerdoelen(selected.ID));
				await Navigation.PushAsync(leerdoelenOverzicht);
				this.IsBusy = false; 
			};
	
		}


						
	}

}


