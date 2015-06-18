using System;
using Xamarin.Forms;

namespace Maius
{
	public class LoginPage : ContentPage
	{
		public LoginPage ()
		{

			Title = "Login";

			var loadingIndicator = new ActivityIndicator (){ 
				//HorizontalOptions = LayoutOptions.CenterAndExpand,
				Color = Color.Black,
				IsRunning = true,
				IsEnabled = true,
				BindingContext = this,
			};
			loadingIndicator.SetBinding (ActivityIndicator.IsVisibleProperty, "IsBusy");

			var btnLogin = new Button {
				Text = "Login",
				TextColor = Color.Black,
				BackgroundColor = Color.FromHex("#FF9D2C"),
			};

			Content = new StackLayout {
				Spacing = 20,
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Entry { Placeholder = "Username" },
					new Entry { Placeholder = "Password", IsPassword = true },
					btnLogin,

				}
			};

			btnLogin.Clicked += async (object sender, EventArgs e) => {
				this.IsBusy = true;
				//await MaiusAPI.Fetch();
				//var vakOverzicht = new NavigationPage(new VakOverzicht());
				var VakOverzicht = new VakOverzicht(await LoadFetch.CallVakken());
				await Navigation.PushAsync(VakOverzicht);
				Navigation.RemovePage(this);
				this.IsBusy = false;
			};
		

		}
	}
}

