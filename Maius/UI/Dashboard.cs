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


