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

			var username = new Entry { Placeholder = "Username" };
			var password = new Entry { Placeholder = "Password", IsPassword = true };

			Content = new StackLayout {
				Spacing = 20,
				Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					username,
					password,
					btnLogin,
				}
			};

			btnLogin.Clicked += async (object sender, EventArgs e) => {
				this.IsBusy = true;
				if(username.Text.Length > 0)
				{
					var output = await MaiusAPI.login(username.Text, password.Text);
					if(output.ERROR)
					{
						await DisplayAlert("Error!", output.message, "OK");
					}
					else if(!output.ERROR)
					{
					var VakOverzicht = new VakOverzicht(await LoadFetch.CallVakken());
					await Navigation.PushAsync(VakOverzicht);
					Navigation.RemovePage(this);
					}
				}
			
				//await Navigation.PushAsync(VakOverzicht);
				//Navigation.RemovePage(this);
				this.IsBusy = false;
			};
		

		}
	}
}

