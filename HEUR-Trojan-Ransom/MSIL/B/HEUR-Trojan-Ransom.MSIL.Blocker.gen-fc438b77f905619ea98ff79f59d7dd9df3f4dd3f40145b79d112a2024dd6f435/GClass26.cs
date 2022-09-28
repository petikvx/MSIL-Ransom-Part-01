using System;
using System.Collections;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

public class GClass26 : GClass24
{
	private class Class12
	{
		public readonly TcpClient tcpClient_0;

		public readonly ManualResetEvent manualResetEvent_0;

		public readonly GClass30<byte[]> gclass30_0;

		public extern Class12(TcpClient tcpClient_1);

		static extern ManualResetEvent smethod_0(bool bool_0);
	}

	[CompilerGenerated]
	private sealed class Class13
	{
		public int int_0;

		public TcpClient tcpClient_0;

		public Class12 class12_0;

		public Thread thread_0;

		public GClass26 gclass26_0;

		public extern Class13();

		internal unsafe void method_0()
		{
			//Discarded unreachable code: IL_0007, IL_000d, IL_0018
			//IL_0008: Incompatible stack heights: 0 vs 1
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected I4, but got Unknown
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}

		internal extern void method_1();

		static extern string smethod_0(object object_0, object object_1);

		static extern void smethod_1(Thread thread_1);
	}

	[CompilerGenerated]
	private sealed class Class14
	{
		public GClass26 gclass26_0;

		public int int_0;

		public extern Class14();

		internal void method_0()
		{
			//Discarded unreachable code: IL_000d, IL_0014, IL_0019
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Expected I4, but got Unknown
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				_003F val = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
				_003F val2 = /*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
				((short[])/*Error near IL_0003: Stack underflow*/)[val] = (short)(int)val2;
			}
		}
	}

	private static int int_3;

	private readonly ConcurrentDictionary<int, Class12> concurrentDictionary_0;

	public TcpListener tcpListener_0;

	private Thread thread_0;

	public extern bool Boolean_0 { get; }

	public static extern int smethod_13();

	private extern void method_1(int int_4);

	public extern bool method_2(int int_4);

	public extern void method_3();

	public extern bool method_4(int int_4, byte[] byte_0);

	public extern string method_5(int int_4);

	public extern bool method_6(int int_4);

	public extern GClass26();

	static bool smethod_14(Thread thread_1)
	{
		//Discarded unreachable code: IL_000b, IL_0014, IL_001e, IL_0023
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		while ((int)/*Error near IL_0005: Stack underflow*/ != 0)
		{
		}
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern int smethod_15(ref int int_4);

	static extern string smethod_16(object object_0, object object_1);

	static Exception smethod_17(string string_0)
	{
		//Discarded unreachable code: IL_000a, IL_0015, IL_001a
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected I4, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
			{
			}
		}
	}

	static extern IPEndPoint smethod_18(IPAddress ipaddress_0, int int_4);

	static extern TcpListener smethod_19(IPEndPoint ipendPoint_0);

	unsafe static Socket smethod_20(TcpListener tcpListener_1)
	{
		short num = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (byte)((double[])/*Error near IL_0002: Stack underflow*/)[num];
			/*Error near IL_0006: ldloc 3 (out-of-bounds)*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern void smethod_21(Socket socket_0, bool bool_1);

	static extern void smethod_22(Socket socket_0, int int_4);

	static void smethod_23(TcpListener tcpListener_1)
	{
		//Discarded unreachable code: IL_0001, IL_0008
		//IL_000e: Expected F4, but got I4
		/*Error: Unknown opcode: 0xFD*/;
	}

	static TcpClient smethod_24(TcpListener tcpListener_1)
	{
		//Discarded unreachable code: IL_0009, IL_001e, IL_001f, IL_0024, IL_002b, IL_0031
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected F4, but got Unknown
		//IL_0019: Incompatible stack heights: 0 vs 1
		//IL_002c: Invalid comparison between Unknown and I8
		_ = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern Thread smethod_25(ThreadStart threadStart_0);

	static extern void smethod_26(Thread thread_1, bool bool_1);

	static extern void smethod_27(Thread thread_1);

	static extern void smethod_28(Thread thread_1, ThreadPriority threadPriority_0);

	unsafe static void smethod_29(TcpListener tcpListener_1)
	{
		//Discarded unreachable code: IL_000c
		//IL_0001: Invalid comparison between Unknown and I8
		long num;
		do
		{
			num = checked((long)/*Error near IL_0001: Stack underflow*/);
		}
		while ((long)/*Error near IL_0006: Stack underflow*/ <= num);
		*(_003F*)(nint)/*Error near IL_0007: Stack underflow*/ = /*Error near IL_0007: Stack underflow*/;
		short num2 = *(short*)(nint)/*Error near IL_0008: Stack underflow*/;
		_ = ((float[])/*Error near IL_0009: Stack underflow*/)[num2];
		_ = ref tcpListener_1;
		/*Error near IL_000b: Unknown opcode: 0xFC*/;
	}

	static extern void smethod_30(Thread thread_1);

	static extern NetworkStream smethod_31(TcpClient tcpClient_0);

	static extern void smethod_32(Stream stream_0);

	static extern void smethod_33(TcpClient tcpClient_0);

	static extern bool smethod_34(IEnumerator ienumerator_0);

	static extern void smethod_35(IDisposable idisposable_0);

	static extern bool smethod_36(EventWaitHandle eventWaitHandle_0);

	static extern string smethod_37(object[] object_0);

	static extern Socket smethod_38(TcpClient tcpClient_0);

	static extern EndPoint smethod_39(Socket socket_0);

	static extern IPAddress smethod_40(IPEndPoint ipendPoint_0);

	static extern string smethod_41(object object_0);
}
