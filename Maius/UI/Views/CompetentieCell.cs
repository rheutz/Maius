using System;
using Xamarin.Forms;

namespace Maius
{
	public class CompetentieCell : ViewCell
	{
		public CompetentieCell()
			{
				var lblOmschrijving = new Label () {
					FontFamily = "HelveticaNeue-Medium",
					FontSize = 14,
					TextColor = Color.Black,
				};
				lblOmschrijving.SetBinding (Label.TextProperty, "Omschrijving");


				var cellLayout = new StackLayout (){ 
					Padding = 10,
					Spacing = 10,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					Children = { lblOmschrijving }
				};

				this.View = cellLayout;
			}
		}
	}


	


