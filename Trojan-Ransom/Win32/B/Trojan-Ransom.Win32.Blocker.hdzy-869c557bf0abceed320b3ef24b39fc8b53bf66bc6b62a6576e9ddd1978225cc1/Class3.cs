using System.Net;
using System.Threading;

internal sealed class Class3
{
	private sealed class Class4
	{
		private string string_0;

		private WebClient webClient_0 = new WebClient();

		private int int_0;

		public Class4(string string_1, int int_1)
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
					while (true)
					{
						webClient_0.DownloadString(string_0);
						Thread.Sleep(int_0);
					}
				}
				catch
				{
					Thread.Sleep(int_0);
				}
			}
		}
	}

	private ThreadStart[] threadStart_0;

	private Thread[] thread_0;

	public string string_0;

	public int int_0 = 20;

	public bool bool_0;

	private Class4[] class4_0;

	public int int_1 = 2;

	public void method_0()
	{
		thread_0 = new Thread[int_1];
		threadStart_0 = new ThreadStart[int_1];
		class4_0 = new Class4[int_1];
		for (int i = 0; i < int_1; i++)
		{
			class4_0[i] = new Class4(string_0, int_0);
			threadStart_0[i] = class4_0[i].method_0;
			thread_0[i] = new Thread(threadStart_0[i]);
			thread_0[i].Start();
		}
		bool_0 = true;
	}

	public void method_1()
	{
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				thread_0[i].Abort();
				thread_0[i] = null;
				threadStart_0[i] = null;
				class4_0[i] = null;
			}
			catch
			{
			}
		}
		bool_0 = false;
	}
}
