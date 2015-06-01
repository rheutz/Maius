using System;
using Xamarin.Forms;

namespace Maius
{
	public class LeerdoelCell : ViewCell
	{
		public LeerdoelCell ()
		{
			var Omschrijving = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				TextColor = Color.Red,
				FontSize = 14
			};

			Omschrijving.SetBinding (Label.TextProperty, "Omschrijving");


			var layout = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = {
					Omschrijving
				}
			
			};

			View = layout;
		}
	}
}

