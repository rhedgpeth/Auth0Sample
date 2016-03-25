using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using NOVAuth0Sample.Droid;
using Auth0.SDK;
using Android.Content;

[assembly: ExportRenderer(typeof(NOVAuth0Sample.LoginPage), typeof(LoginPageRenderer))]
namespace NOVAuth0Sample.Droid
{
	public class LoginPageRenderer : PageRenderer
	{
		public LoginPageRenderer()
		{
			ShowLoginPage();
		}

		async void ShowLoginPage()
		{
			var auth0 = new Auth0Client(Constants.Auth0_Domain, Constants.Auth0_ClientId);

			if (auth0 != null)
			{
				var profile = await auth0.LoginAsync(this.Context, Constants.Auth0_Connection, true);

				if (profile != null)
				{
					Console.WriteLine("Logged in as " + profile.Profile["name"]);
				}
			}
		}
	}
}

