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
			};

			var btnTest = new Button {
				Text = "Click me",
				BackgroundColor = Color.Green,
				TextColor = Color.Blue,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.End
			};



			btnTest.Clicked += (object sender, EventArgs e) => 
			{
				MaiusAPI.Fetch();

			};


				


			Content = new StackLayout { 
				Children = {
					listView, btnTest
				}
			};



		}
						
	}
}


