using System;
using Xamarin.Forms;

namespace Maius
{
	public class VakCell : ViewCell
	{
		public VakCell ()
		{
			var Omschrijving = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				FontFamily = "HalveticaNueu-Medium",
				TextColor = Color.Black,
				FontSize = 18,

			};

			Omschrijving.SetBinding (Label.TextProperty, "Omschrijving");


			var layout = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Spacing = 10,
				Padding = 10,
				Children = {
					Omschrijving
				}
			
			};

			View = layout;
		}
	}

}