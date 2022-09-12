using System;
using System.Net;
using System.Threading;

namespace WindowsFormsApp32;

public static class Web
{
	public static void WebPage()
	{
		string[] array = new string[5] { "http://google.com", "http://bing.com", "http://yahoo.com", "http://facebook.com", "http://twitter.com" };
		for (int i = 0; i < array.Length; i++)
		{
			using WebClient webClient = new WebClient();
			try
			{
				Console.WriteLine(webClient.DownloadString("http://google.com"));
				new ManualResetEvent(initialState: false).WaitOne(2000);
			}
			catch
			{
			}
		}
	}
}
