using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace Maius
{
	public class LeerdoelenOverzicht : ContentPage
	{
		public LeerdoelenOverzicht (Vak vak, List<Leerdoel> vakLeerdoelen)
		{
			Title = " Leerdoelen";

			var loadingIndicator = new ActivityIndicator (){ 
				//HorizontalOptions = LayoutOptions.CenterAndExpand,
				Color = Color.Black,
				IsRunning = true,
				IsEnabled = true,
				BindingContext = this,
			};

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

			listView.ItemTapped += async (object sender, ItemTappedEventArgs e) => 
			{
				this.IsBusy = true;
				Leerdoel selected = (Leerdoel)listView.SelectedItem;
				var leerdoelPage = new LeerdoelPage(selected, await MaiusAPI.getCompetentiesByLeerdoelID(selected.ID));
				await Navigation.PushAsync(leerdoelPage);
				this.IsBusy = false;
			};


		}
	}
}


