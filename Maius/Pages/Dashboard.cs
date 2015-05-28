using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace Maius
{
	public class Dashboard : ContentPage
	{

		public Dashboard ()
		{
			Grid grid = new Grid
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				RowDefinitions = 
				{
					new RowDefinition { Height = GridLength.Auto },
					new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
				},
				ColumnDefinitions = 
				{
					new ColumnDefinition { Width = GridLength.Auto },
					new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
				}
				};

			grid.Children.Add(new Label
				{
					Text = "Grid",
					FontSize = 50,
					FontAttributes = FontAttributes.Bold,
					HorizontalOptions = LayoutOptions.Center
				}, 0, 3, 0, 1);

			grid.Children.Add(new Label
				{
					Text = "Autosized cell",
					TextColor = Color.White,
					BackgroundColor = Color.Blue
				}, 0, 1);

			grid.Children.Add(new BoxView
				{
					Color = Color.Silver,
					HeightRequest = 0
				}, 1, 1);

			grid.Children.Add(new BoxView
				{
					Color = Color.Teal
				}, 0, 2);
						
			// Build the page.
			this.Content = grid;

		}
	}
}


