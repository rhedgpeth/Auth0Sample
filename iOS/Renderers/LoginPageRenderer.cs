using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using CoreGraphics;
using Auth0;
using Auth0.SDK;

[assembly: ExportRenderer(typeof(NOVAuth0Sample.LoginPage), typeof(NOVAuth0Sample.iOS.LoginPageRenderer))]

namespace NOVAuth0Sample.iOS
{
	public class LoginPageRenderer : PageRenderer
	{
		public async override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);

			var auth0 = new Auth0Client(Constants.Auth0_Domain, Constants.Auth0_ClientId);

			if (auth0 != null)
			{
				var user = await auth0.LoginAsync(ViewController, Constants.Auth0_Connection, true);

				if (user != null)
				{
					Console.WriteLine("Logged in as " + user.Profile["name"]);
				}
			}
		}
	}
}


