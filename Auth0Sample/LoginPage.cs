using System;

using Xamarin.Forms;

namespace NOVAuth0Sample
{
	public class LoginPage : ContentPage
	{
		public LoginPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


