using System.Net;

namespace HRemout.Networking;

internal class CheckConnect
{
	public static bool CheckForInternetConnection()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("http://google.com/generate_204"))
			{
				return true;
			}
		}
		catch
		{
			return false;
		}
	}
}
