using System;
using System.Net;
using System.Net.Sockets;
using ns0;

namespace ns3;

internal class Class10
{
	private static Socket socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

	public static void smethod_0()
	{
		try
		{
			uint num = 3000u;
			for (int i = 0; i < Class12.string_2.Length; i++)
			{
				num += Class12.string_2[i];
			}
			Class12.ushort_0 = (ushort)(num % 65000u);
			socket_0.Bind(new IPEndPoint(IPAddress.Any, Class12.ushort_0));
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
			Class12.ushort_0 = 0;
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
				new Class9(socket)._003CdlY();
			}
			((Socket)iasyncResult_0.AsyncState).BeginAccept(smethod_2, (Socket)iasyncResult_0.AsyncState);
		}
		catch
		{
		}
	}
}
