using System;
using Xamarin.Forms;

namespace Maius
{
	public class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			Title = "Login";

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
				//await Navigation.PushAsync(new VakOverzicht());
			};
		

		}
	}
}

