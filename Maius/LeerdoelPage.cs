using System;


using Xamarin.Forms;

namespace Maius
{
	public class LeerdoelPage : ContentPage
	{
		public LeerdoelPage (Leerdoel leerdoel)
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = leerdoel.Omschrijving + "/n/n" + leerdoel.Rating }
				}
			};
		}
	}
}


