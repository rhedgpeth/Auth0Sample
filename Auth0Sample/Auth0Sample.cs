using System;

using Xamarin.Forms;

namespace NOVAuth0Sample
{
	public class App : Application
	{
		public App()
		{
			MainPage = new NavigationPage(new MainPage());
		}
	}
}

