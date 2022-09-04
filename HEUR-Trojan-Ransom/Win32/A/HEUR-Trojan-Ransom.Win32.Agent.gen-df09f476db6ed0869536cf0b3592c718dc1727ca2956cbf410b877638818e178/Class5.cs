using System.Net;
using System.Threading;

internal class Class5
{
	private class Class6
	{
		private string[] string_0;

		public Class6(string[] string_1)
		{
			Class51.smethod_0();
			base._002Ector();
			string_0 = string_1;
		}

		public void method_0()
		{
			try
			{
				Class8.smethod_0(string_0);
				string[] array = string_0;
				foreach (string text in array)
				{
					try
					{
						WebClient webClient = new WebClient();
						webClient.Headers.Add("referer", text);
						webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2138.3 Safari/537.36");
						webClient.DownloadString(text);
					}
					catch
					{
					}
					Thread.Sleep(30000);
				}
			}
			catch
			{
			}
		}
	}

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static string[] string_0;

	private static Class6[] class6_0;

	public static int int_0;

	public static void smethod_0()
	{
		thread_0 = new Thread[int_0];
		threadStart_0 = new ThreadStart[int_0];
		class6_0 = new Class6[int_0];
		for (int i = 0; i < int_0; i++)
		{
			class6_0[i] = new Class6(string_0);
			threadStart_0[i] = class6_0[i].method_0;
			thread_0[i] = new Thread(threadStart_0[i]);
			thread_0[i].Start();
		}
	}

	public static void smethod_1()
	{
		for (int i = 0; i < int_0; i++)
		{
			try
			{
				thread_0[i].Abort();
				thread_0[i].Join();
			}
			catch
			{
			}
		}
	}

	public Class5()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
