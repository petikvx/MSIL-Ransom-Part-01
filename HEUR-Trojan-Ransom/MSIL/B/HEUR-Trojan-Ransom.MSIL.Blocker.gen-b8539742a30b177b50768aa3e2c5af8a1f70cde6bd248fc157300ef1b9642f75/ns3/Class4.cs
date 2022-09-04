using System;
using System.Net;
using System.Net.Sockets;
using ns6;

namespace ns3;

internal class Class4
{
	private static Socket socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

	public static void smethod_0()
	{
		try
		{
			uint num = 3000u;
			for (int i = 0; i < Class13.string_2.Length; i++)
			{
				num += Class13.string_2[i];
			}
			Class13.ushort_0 = (ushort)(num % 65000u);
			socket_0.Bind(new IPEndPoint(IPAddress.Any, Class13.ushort_0));
			socket_0.Listen(50);
			socket_0.BeginAccept(smethod_2, socket_0);
		}
		catch
		{
			smethod_1();
		}
	}

	public static void smethod_1()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			Class13.ushort_0 = 0;
			socket_0.Close();
		}
		catch
		{
		}
	}

	private static void smethod_2(IAsyncResult iasyncResult_0)
	{
		try
		{
			Socket socket = ((Socket)iasyncResult_0.AsyncState).EndAccept(iasyncResult_0);
			if (socket != null)
			{
				new Class3(socket).method_0();
			}
			((Socket)iasyncResult_0.AsyncState).BeginAccept(smethod_2, (Socket)iasyncResult_0.AsyncState);
		}
		catch
		{
		}
	}
}
