using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

internal class Class48
{
	public GClass15 gclass15_0;

	public GClass15 gclass15_1;

	public GClass16 gclass16_0;

	public GClass19 gclass19_0;

	private List<GClass7> list_0;

	private int int_0;

	private int int_1;

	public Class48(GClass16 gclass16_1, GClass15 gclass15_2, GClass15 gclass15_3, int int_2, int int_3)
	{
		Class51.smethod_0();
		list_0 = new List<GClass7>();
		int_0 = 10000;
		int_1 = 128;
		base._002Ector();
		gclass19_0 = new GClass19(new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp), int_1);
		gclass16_0 = gclass16_1;
		gclass15_0 = gclass15_2;
		gclass15_1 = gclass15_3;
		int_1 = int_2;
		int_0 = int_3;
	}

	public void method_0()
	{
		if (gclass15_1.method_4() != null && gclass15_1.method_6() > -1)
		{
			SocketAsyncEventArgs socketAsyncEventArgs = new SocketAsyncEventArgs();
			socketAsyncEventArgs.RemoteEndPoint = new IPEndPoint(gclass15_1.method_10(), gclass15_1.method_6());
			SocketAsyncEventArgs socketAsyncEventArgs2 = socketAsyncEventArgs;
			socketAsyncEventArgs2.Completed += method_1;
			gclass19_0.method_1(new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp));
			if (!gclass19_0.method_0().ConnectAsync(socketAsyncEventArgs2))
			{
				method_2(socketAsyncEventArgs2);
			}
		}
		else
		{
			gclass16_0.gclass19_0.method_5();
		}
	}

	private void method_1(object sender, SocketAsyncEventArgs e)
	{
		byte[] array = gclass15_0.method_11();
		if (e.SocketError != 0)
		{
			Console.WriteLine("Error while connecting: {0}", e.SocketError.ToString());
			array[1] = 3;
		}
		else
		{
			array[1] = 0;
		}
		gclass16_0.gclass19_0.method_7(array);
		SocketAsyncOperation lastOperation = e.LastOperation;
		if (lastOperation == SocketAsyncOperation.Connect)
		{
			method_2(e);
		}
	}

	private void method_2(SocketAsyncEventArgs socketAsyncEventArgs_0)
	{
		try
		{
			foreach (GClass7 item in GClass13.smethod_5(typeof(GClass7)))
			{
				GClass11.smethod_11(list_0, item);
			}
			gclass16_0.gclass19_0.Event_1 += method_5;
			gclass19_0.Event_1 += method_4;
			gclass19_0.Event_0 += method_3;
			gclass16_0.gclass19_0.method_4();
			gclass19_0.method_4();
		}
		catch
		{
		}
	}

	private void method_3(object sender, GEventArgs1 e)
	{
		Console.WriteLine("Remote DC'd");
		gclass16_0.gclass19_0.method_5();
	}

	private void method_4(object sender, GEventArgs3 e)
	{
		e.method_9(gclass15_1);
		foreach (GClass7 item in list_0)
		{
			if (item.imethod_0())
			{
				item.vmethod_0(this, e);
			}
		}
		gclass16_0.gclass19_0.method_8(e.method_2(), e.method_6(), e.method_4());
		gclass19_0.method_4();
	}

	private void method_5(object sender, GEventArgs3 e)
	{
		e.method_9(gclass15_1);
		foreach (GClass7 item in list_0)
		{
			if (item.imethod_0())
			{
				item.vmethod_1(this, e);
			}
		}
		gclass19_0.method_8(e.method_2(), e.method_6(), e.method_4());
		gclass16_0.gclass19_0.method_4();
	}
}
