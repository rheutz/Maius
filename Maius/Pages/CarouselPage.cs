using System;

using Xamarin.Forms;

namespace Maius
{
	public class carouselPage : CarouselPage
	{
		public carouselPage ()
		{
			
			
			this.Children.Add (new Dashboard ());
			this.Children.Add (new VakOverzicht());
		}
	}
}


