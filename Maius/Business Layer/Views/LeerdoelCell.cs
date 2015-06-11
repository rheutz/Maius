using System;
using Xamarin.Forms;

namespace Maius
{
	public class LeerdoelCell : ViewCell
	{
		public LeerdoelCell()
		{
			var lblOmschrijving = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 16,
				//FontAttributes = FontAttributes.Bold,
				TextColor = Color.Black,
			};
			lblOmschrijving.SetBinding (Label.TextProperty, "Omschrijving");

			var lblStar = new Label () {
				FontSize = 16,
				FontAttributes = FontAttributes.Bold,
				TextColor = Color.Black,
			};

			lblStar.SetBinding (Label.TextProperty, "Rating");

			var imgStar = new Image () {
				HeightRequest = 16,
				WidthRequest = 16,
			};

			imgStar.Source = ImageSource.FromResource ("Maius.UI.Images.star.png");

			var starStack = new StackLayout () {
				Spacing = 5,
				Orientation = StackOrientation.Horizontal,
				Children = { imgStar, lblStar }
			};

			var cellLayout = new StackLayout (){ 
				//Padding = new Thickness(10, 0, 0,0),
				Spacing = 0,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { lblOmschrijving, starStack }
			};

			this.View = cellLayout;
		}
	}
}




