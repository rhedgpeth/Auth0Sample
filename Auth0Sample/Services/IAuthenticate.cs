using System;
using System.Threading.Tasks;

namespace NOVAuth0Sample
{
	public interface IAuthenticate
	{
		Task<User> Login(string username, string password);
	}
}

