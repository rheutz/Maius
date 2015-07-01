using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace Maius
{
	public class LeerdoelenOverzicht : ContentPage
	{
		public LeerdoelenOverzicht (List<Leerdoel> vakLeerdoelen)
		{

			//pagina opbouw
			Title = " Leerdoelen";

			var listView = new ListView {
				
				ItemTemplate = new DataTemplate (typeof(LeerdoelCell)),
				HasUnevenRows = true,
				ItemsSource = vakLeerdoelen,
			};
				
			Content = new StackLayout { 
				Padding = 10,
				Spacing = 10,
				Children = {
					listView
				}
			};

			//logica voor het klikken op een leerdoel
			listView.ItemTapped += async (object sender, ItemTappedEventArgs e) => 
			{
				this.IsBusy = true;
				Leerdoel selected = (Leerdoel)listView.SelectedItem;
				var leerdoelPage = new LeerdoelPage(selected, await LoadFetch.CallCompetenties(selected.ID));
				await Navigation.PushAsync(leerdoelPage);
				this.IsBusy = false;
			};


		}
	}
}


