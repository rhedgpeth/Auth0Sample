using System;
using System.Threading.Tasks;
using Auth0.SDK;
using NOVAuth0Sample.Android;


[assembly: Xamarin.Forms.Dependency(typeof(Authenticate))]
namespace NOVAuth0Sample.Android
{
	public class Authenticate : IAuthenticate
	{
		public async Task<User> Login(string username, string password)
		{
			User user = null;

			var auth0 = new Auth0Client(Constants.Auth0_Domain, Constants.Auth0_ClientId);

			if (auth0 != null)
			{

				var aDFSUser = await auth0.LoginAsync(Constants.Auth0_Connection, username, password);

				if (aDFSUser != null)
				{
					Console.WriteLine("Logged in as " + aDFSUser.Profile["name"]);
				}
			}

			return user;
		}
	}
}
