using System;

using Xamarin.Forms;

namespace NOVAuth0Sample
{
	public class MainPage : ContentPage
	{
		private IAuthenticate authenticate;

		public MainPage()
		{
			var button1 = new Button
			{
				Text = "Go to Login Page"
 			};
			button1.Clicked += OnButton1Clicked;

			var button2 = new Button
			{
				Text = "Manual Login"
			};
			button2.Clicked += OnButton2Clicked;

			Content = new StackLayout
			{
				Padding = new Thickness(0, 50, 0, 0),
				Children = {
					button1,
					button2
				}
			};
		}

		void OnButton1Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new LoginPage());
		}

		async void OnButton2Clicked(object sender, EventArgs e)
		{
			await DependencyService.Get<IAuthenticate>().Login("put_username_here", "put_password_here");
		}
	}
}


