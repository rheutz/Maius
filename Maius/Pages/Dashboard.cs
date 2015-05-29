using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace Maius
{
	public class Dashboard : ContentPage
	{

		public Dashboard ()
		{
			BackgroundColor = Color.Gray;

			Grid grid = new Grid
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
//				RowDefinitions = 
//				{
//					new RowDefinition { Height = GridLength.Auto },
//					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
//				},
//				ColumnDefinitions = 
//				{
//					new ColumnDefinition { Width = GridLength.Auto },
//					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
//				}
		};

//			grid.Children.Add(new Label
//				{
//					Text = "Grid",
//					FontSize = 50,
//					FontAttributes = FontAttributes.Bold,
//					HorizontalOptions = LayoutOptions.Center,
//					BackgroundColor = Color.Green,
//				}, 0, 3, 0, 1);
//			
			grid.Padding = 4;


			grid.Children.Add (new BoxView {
				BackgroundColor = Color.FromHex("#52423E"),

			}, 0, 0);

			grid.Children.Add (new BoxView {
				BackgroundColor = Color.FromHex("#52423E"),
			}, 0, 1);


						
			// Build the page.
			this.Content = grid;

		}
	}
}


