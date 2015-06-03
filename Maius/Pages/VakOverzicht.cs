using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace Maius
{
	public class VakOverzicht : ContentPage
	{
		public VakOverzicht ()
		{
			Title = " Kies vak";

			var loadingIndicator = new ActivityIndicator (){ 
				//HorizontalOptions = LayoutOptions.CenterAndExpand,
				Color = Color.Black,
				IsRunning = true,
				IsEnabled = true,
				BindingContext = this,
			};

			var listView = new ListView {
				ItemTemplate = new DataTemplate (typeof(VakCell)),
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
				this.IsBusy = true;
				Vak selected = (Vak)listView.SelectedItem;
				var leerdoelenOverzicht = new LeerdoelenOverzicht(selected,await MaiusAPI.getLeerdoelenByVakID(selected.ID));
				await Navigation.PushAsync(leerdoelenOverzicht);
//				var vakPage = new LeerdoelPage(selected);
//				await Navigation.PushAsync(leerdoelPage);
				this.IsBusy = false; 
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


