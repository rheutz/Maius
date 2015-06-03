using System;


using Xamarin.Forms;
using System.Collections.Generic;

namespace Maius
{
	public class LeerdoelPage : ContentPage
	{
		public LeerdoelPage (Leerdoel leerdoel, List<Competentie> leerdoelenCompetenties)
		{
			Title = " Beoordelen";

			var listView = new ListView {
				Header = "Bijbehorende competenties",
				ItemTemplate = new DataTemplate (typeof(CompetentieCell)),
				HasUnevenRows = true,
				ItemsSource = leerdoelenCompetenties,
			};

			var lbLeerdoel = new Label {
				Text = leerdoel.Omschrijving,
				FontSize = 16,
				FontFamily = "HalveticaNeue-Medium",
				TextColor = Color.Black,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.Start,
			};

			Content = new StackLayout {
				Padding = 10,
				Spacing = 10,
				Children = {
					lbLeerdoel, listView
				}
			};
		}
	}
}


