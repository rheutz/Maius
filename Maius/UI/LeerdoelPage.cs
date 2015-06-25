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

			//Ratingbar
			var lbRating = new Label {
				Text = "Beoordeel leerdoel",
				FontSize = 18,
				FontAttributes = FontAttributes.Bold,
				TextColor = Color.Black,
			};

			var imgStar1 = new Image {
				HeightRequest = 60,
				WidthRequest = 60,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png"),
			
			};
			var imgStar2 = new Image {
				HeightRequest = 60,
				WidthRequest = 60,
				Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png"),
			};
			var imgStar3 = new Image {
				HeightRequest = 60,
				WidthRequest = 60,
				Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png"),
			};
			var imgStar4 = new Image {
				HeightRequest = 60,
				WidthRequest = 60,
				Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png"),
			};
			var imgStar5 = new Image {
				HeightRequest = 60,
				WidthRequest = 60,
				Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png"),
			};

			var tapStar1 = new TapGestureRecognizer ();
			imgStar1.GestureRecognizers.Add (tapStar1);
			tapStar1.Tapped += (object sender, EventArgs e) => {
				imgStar1.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar2.Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png");
				imgStar3.Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png");
				imgStar4.Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png");
				imgStar5.Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png");

				leerdoel.Rating = 1;			//set rating 
			};

			var tapStar2 = new TapGestureRecognizer ();
			imgStar2.GestureRecognizers.Add (tapStar2);
			tapStar2.Tapped += (object sender, EventArgs e) => {
				imgStar1.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar2.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar3.Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png");
				imgStar4.Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png");
				imgStar5.Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png");

				leerdoel.Rating = 2;
			};
				
			var tapStar3 = new TapGestureRecognizer ();
			imgStar3.GestureRecognizers.Add (tapStar3);
			tapStar3.Tapped += (object sender, EventArgs e) => {
				imgStar1.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar2.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar3.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar4.Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png");
				imgStar5.Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png");

				leerdoel.Rating = 3;
			};
				
			var tapStar4 = new TapGestureRecognizer ();
			imgStar4.GestureRecognizers.Add (tapStar4);
			tapStar4.Tapped += (object sender, EventArgs e) => {
				imgStar1.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar2.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar3.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar4.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar5.Source = ImageSource.FromResource("Maius.UI.Images.star_outline.png");
				leerdoel.Rating = 4;

			};
				
			var tapStar5 = new TapGestureRecognizer ();
			imgStar5.GestureRecognizers.Add (tapStar5);
			tapStar5.Tapped += (object sender, EventArgs e) => {
				imgStar1.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar2.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar3.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar4.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				imgStar5.Source = ImageSource.FromResource("Maius.UI.Images.star_selected.png");
				leerdoel.Rating = 5;
			};

			var btnOpslaan = new Button {
				Text = "Opslaan",
				TextColor = Color.Black,
				BackgroundColor = Color.FromHex("#FF9D2C"),
			};

			var ratingStack = new StackLayout { 
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Children = { imgStar1, imgStar2, imgStar3, imgStar4, imgStar5 },
			};

			Content = new StackLayout {
				Padding = 10,
				Spacing = 20,
				Children = {
					lbLeerdoel, lbRating, ratingStack, btnOpslaan, listView
				}
			};

			btnOpslaan.Clicked += async (object sender, EventArgs e) => 
			{
				
			};
		}
	}
}


